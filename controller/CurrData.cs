﻿using Final_Year_Project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;

namespace Final_Year_Project
{

    internal static class CurrData
    {
        public static BindingList<ClientData> clientData = new BindingList<ClientData>();
        private static string connectionString = System.Windows.Forms.Application.StartupPath + "\\" + "localDB.sqlite";
        public static Dictionary<string, Tuple<string, bool>> databaseScheme = new Dictionary<string, Tuple<string, bool>>();   //Key is display name, tuple contains data type as string, and if it is nullable
        public static string[] dataTypes = { "NCHAR(100)", "INTEGER", "DATE", "DATETIME", "TEXT", "REAL" };
        private static List<UpdatedField> changes = new List<UpdatedField>();
        private static bool editPermissions = true;
        private static bool adminPermissions = true;

        public static bool EditingPermissions { get => editPermissions; }
        public static bool AdminPermissions { get => adminPermissions; }

        public static string GetClientName(long clientID) 
        {
            foreach (ClientData client in clientData)
            {
                if (client.Id == clientID)
                {
                    return client.displayName;
                }
            }
            return "No Such Client Found";
        }

        public static Field[] GetClientFields(long clientID)
        {
            foreach (ClientData client in clientData)
            {
                if (client.Id == clientID)
                {
                    return client.GetAllFields();
                }
            }
            return null;
        }

        private static bool ValidateInput(string fieldName, string data)
        {
            //Implement at least some form of validation
            //get data type from scheme
            //then try parseing
            return true;
        }

        public static void UpdateField(long clientID,string fieldName,object newData)
        {
            UpdatedField change;
            if (!ValidateInput(fieldName, newData.ToString()))
                return;
            foreach (ClientData client in clientData)   //Holy shit is this not the way to do this
            {
                if (client.Id == clientID)
                {
                    change = new UpdatedField(clientID, fieldName, newData, client.GetFieldData(fieldName));
                    client.SetField(fieldName, newData);
                    changes.Add(change);
                }
            }
        }

        public static string GetConnectionString()
        { return connectionString; }

        public static void SetConnenctionString(string newConnectionString) { connectionString = newConnectionString; }

        public static void SaveLocalDatabase()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();

                foreach (UpdatedField field in changes)
                {
                    string temp_fieldValue;
                    if (!(databaseScheme[field.getFieldName()].Item2 == false && (field.getValue() == null || (string)field.getValue() == "")))
                    {

                        if (databaseScheme[field.getFieldName()].Item1 == "DATETIME" || databaseScheme[field.getFieldName()].Item1 == "DATE")
                            temp_fieldValue = "datetime(\"" + field.getValue().ToString() + "\"),";
                        else if (databaseScheme[field.getFieldName()].Item1 == "NCHAR(100)" || databaseScheme[field.getFieldName()].Item1 == "TEXT")
                            temp_fieldValue = "\"" + field.getValue().ToString() + "\",";
                        else
                            temp_fieldValue = field.getValue().ToString();

                        command.CommandText = "UPDATE Client SET " + ConvertFieldNameToDBColumn(field.getFieldName()) + "= " + temp_fieldValue.TrimEnd(',') + " WHERE Id=" + field.getId().ToString();
                        command.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
        }

        private static bool SaveNewClientToDB(ClientData newClient)
        {
            //try
            //{
                using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
                {
                    con.Open();
                    SQLiteCommand command = con.CreateCommand();
                    string columnNames = "";
                    string values = "";

                    foreach (Field field in newClient.GetAllFields())
                    {
                    columnNames += ConvertFieldNameToDBColumn(field.fieldName) + ',';
                    if (field.GetType() == typeof(FieldDateTime) || field.GetType() == typeof(FieldDate))
                        values += "datetime(\"" + field.GetDataAsString() + "\"),";
                    else if (field.GetType() == typeof(FieldLongString) || field.GetType() == typeof(FieldShortString))
                        values += "\""+field.GetDataAsString() + "\",";
                    else
                        values += field.GetDataAsString() + ",";
                    }
                    columnNames = columnNames.TrimEnd(',');
                    values = values.TrimEnd(',');
                    command.CommandText = "INSERT INTO Client(" + columnNames + ") VALUES(" + values + ");";
                    command.ExecuteNonQuery();
                    con.Close();
                }
            //}
            //catch (Exception ex) { return false; }
            return true;
        }

        private static string ConvertFieldNameToDBColumn(string fieldName)
        {
            return fieldName.Trim().Replace(' ', '_');
        }

        private static string ConvertColumnNameToDisplayName(string columnName)
        {
            return columnName.Trim().Replace('_', ' ');
        }

        public static void LoadLocalDatabase() 
        {

            List<ClientData> tempClient = new List<ClientData>();
            List<Field> tempFields = new List<Field>();

            if (!System.IO.File.Exists(connectionString)) { System.Windows.Forms.MessageBox.Show("DB file doesnt exist");return; }

            //try   //try removed for debugging purposes
            //{
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                connection.Open();

                LoadDatabaseScheme(connection);

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Client";
                var reader = command.ExecuteReader();

                //List<ClientData> tempClient = new List<ClientData>();
                while (reader.Read())
                {
                    //List<Field> tempFields = new List<Field>();
                    for (int i = 0; i < reader.VisibleFieldCount; i++)
                    {
                        string type = databaseScheme[ConvertColumnNameToDisplayName(reader.GetName(i))].Item1;
                        string tempFieldName = ConvertColumnNameToDisplayName(reader.GetName(i));
                        switch (type)
                        {
                            case "NCHAR(100)":
                                tempFields.Add(new FieldShortString(tempFieldName, reader[i]));
                                break;
                            case "TEXT":
                                tempFields.Add(new FieldLongString(tempFieldName, reader[i]));
                                break;
                            case "INTEGER":
                                tempFields.Add(new FieldInteger(tempFieldName, reader[i]));
                                break;
                            case "REAL":
                                tempFields.Add(new FieldReal(tempFieldName, reader[i]));
                                break;
                            case "DATE":
                                tempFields.Add(new FieldDate(tempFieldName, reader[i]));
                                break;
                            case "DATETIME":
                                tempFields.Add(new FieldDateTime(tempFieldName, reader[i]));
                                break;
                            default:
                                tempFields.Add(new Field(tempFieldName, reader[i]));
                                break;
                        }
                    }
                    tempClient.Add(new ClientData(tempFields.ToArray()));
                    tempFields.Clear();
                }
                //Connect to database
                //Get list of clients and fields into relevent classes
                //Update list in forms

                connection.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //    //Handle this in some way
            //}

            clientData = new BindingList<ClientData>(tempClient);
        }

        public static void CreateNewClient(Field[] fields)
        {
            //This bit was usefull once upon a time, I dont dare get rid of it but client should not be created without any fields
            if (fields == null)
            {
                List<Field> temp = new List<Field>();
                Random rand = new Random();

                temp.Add(new Field("Name","New Client"));
                temp.Add(new Field("Address",null));
                temp.Add(new FieldDateTime("DateOfBirth",null));

                fields = temp.ToArray();
            }
            //wrap in try catch block
                ClientData newClient = new ClientData(fields);
            if (SaveNewClientToDB(newClient))
                LoadLocalDatabase();
          

        }

        public static void CreateNewClient(ClientData clientToAdd) { clientData.Add(clientToAdd); } //unused and for good reason,should not just add to model, use other method with fields instead

        private static void LoadDatabaseScheme(SQLiteConnection con)
        {
            //try
            //{
                databaseScheme.Clear();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "PRAGMA table_info(Client);";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tempName = (string)reader["name"];
                    string tempType = (string)reader["type"];
                    bool tempNullable = reader["notnull"].ToString() == "0"; //This not work

                    databaseScheme.Add(tempName.Replace('_',' '),new Tuple<string, bool> (tempType,tempNullable));
                }
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("Failed to load database scheme");
            //    databaseScheme.Clear();
            //}
        }



        public static Appointment[] GetAppointmentsByDate(DateTime date)
        {
            string searchDate = date.ToString("yyyy-MM-dd");
            List<Appointment> tempAppointments = new List<Appointment>();

            if (databaseScheme.Count == 0)  //For checking if a database is even loaded
                return null;

            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            { 
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "SELECT * FROM Appointment WHERE date(Time) = date(\"" + searchDate + "\");";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ClientID"].ToString());
                    DateTime time = Convert.ToDateTime(reader["Time"]);
                    string notes = reader["Notes"].ToString();

                    tempAppointments.Add(new Appointment(id, time, notes));
                }
            }
            return tempAppointments.ToArray();
        }

        public static Appointment[] GetAppointmentsByClientID(long id)
        {
            List<Appointment> tempAppointments = new List<Appointment>();

            if (databaseScheme.Count == 0)  //For checking if a database is even loaded
                return null;

            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "SELECT * FROM Appointment WHERE ClientID = "+id+";";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime time = Convert.ToDateTime(reader["Time"]);
                    string notes = reader["Notes"].ToString();

                    tempAppointments.Add(new Appointment(id, time, notes));
                }
            }
            return tempAppointments.ToArray();
        }

        public static bool ClientHasAppointmentOnDate(long clientID ,DateTime date)
        {
            bool returnValue = false;
            foreach(Appointment app in GetAppointmentsByClientID(clientID)) 
            { 
                if (app.Time.Date == date.Date)
                    returnValue = true;
            }
            return returnValue;
        }

        public static void SaveAppointment(Appointment appointment)
        {
            //Save to db
            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Appointment(ClientID,Time,Notes) VALUES(" + appointment.ClientID + ",datetime(\"" + appointment.Time.ToString("yyyy-MM-dd HH:mm") + "\"),\""+appointment.Notes+"\");";
                command.ExecuteNonQuery();
            }
        }
        public static void SaveChangesToAppointment(Appointment oldApp,DateTime? newTime = null,string notes =null)
        {
            //DateTime? Means Nullable<DateTime> used as default value

            string commandText = "UPDATE Appointment SET ";

            if (newTime != null)
            { 
                commandText += "Time = datetime(\""+newTime?.ToString("yyyy-MM-dd HH:mm")+"\"), ";
            }
            if (notes != null)
            {
                commandText += "Notes = \"" + notes + "\" ";
            }
            commandText = commandText.TrimEnd(',');

            // WHERE ClientID = 1 AND datetime(Time) = datetime("2024-05-02 11:45");

            commandText += "WHERE ClientID = " + oldApp.ClientID + " AND datetime(\"Time\") = datetime(\"" + oldApp.Time.ToString("yyyy-MM-dd HH:mm") + "\");";

            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = commandText;
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteAppointment(Appointment appointment) 
        {
            //DELETE FROM Appointment Where ClientID = 1 AND datetime(Time) = datetime("2024-05-04 11:45:00");
            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM Appointment Where ClientID = "+appointment.ClientID+" AND datetime(Time) = datetime(\""+appointment.Time.ToString("yyyy-MM-dd HH:mm")+"\");";
                command.ExecuteNonQuery();
            }
        }

        public static void SetPermissions(int level)
        {
            switch (level)
            {
                case 0:     //Read only
                    editPermissions = false; adminPermissions = false; break;
                case 1:     //Regular Employee no admin
                    editPermissions = true; adminPermissions = false; break;
                case 2:     //Administartive permissions
                    editPermissions = true; adminPermissions = true; break;
                default:    //Default should not be reached if it is something has gone terribly wrong
                    editPermissions = false; adminPermissions = false; break;
            }
        }
    }
}
