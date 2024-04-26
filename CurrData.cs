using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace Final_Year_Project
{

    internal static class CurrData
    {
        public static BindingList<ClientData> clientData= new BindingList<ClientData>();
        private static string connectionString = System.Windows.Forms.Application.StartupPath + "\\" + "localDB.sqlite" ;
        public static Dictionary<string,Tuple< string, bool>> databaseScheme = new Dictionary<string, Tuple<string,bool>>();   //Key is display name, tuple contains data type as string, and if it is nullable
        public static string[] dataTypes = { "NCHAR(100)", "INTEGER", "DATE","DATETIME", "TEXT", "REAL" };
        private static List<UpdatedField> changes = new List<UpdatedField>();
        public static object GetFieldValue(int clientIndex,string fieldName) 
        {
            return null;
        }

        private static bool ValidateInput(string fieldName, string data)
        {
            //Implement at least some form of validation
            //get data type from scheme
            //then try parseing
            return true;
        }

        public static void UpdateField(int clientID,string fieldName,object newData)
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
                    command.CommandText = "UPDATE Client SET " + field.getFieldName().Trim().Replace(' ', '_') + "='" + field.getValue().ToString() + "' WHERE Id=" + field.getId().ToString();
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
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
                        string type = reader.GetFieldType(i).ToString();
                        switch (type)
                        {
                            case "System.DateTime":
                                //tempFields.Add(new FieldDateTime(reader.GetName(i), reader[i]));
                                break;
                            default:
                                tempFields.Add(new Field(reader.GetName(i), reader[i]));
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
            //Need get Id from database
            if (fields == null)
            {
                List<Field> temp = new List<Field>();
                Random rand = new Random();
                temp.Add(new Field("Id", rand.Next(100,999))); //Good God

                temp.Add(new Field("Name","New Client"));
                temp.Add(new Field("Address",null));
                temp.Add(new FieldDateTime("DateOfBirth",null));

                fields = temp.ToArray();
            }
            
            clientData.Add(new ClientData(fields));
        }

        public static void CreateNewClient(ClientData clientToAdd) { clientData.Add(clientToAdd); }

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
                    bool tempNullable = reader["notnull"].Equals(0);

                    databaseScheme.Add(tempName.Replace('_',' '),new Tuple<string, bool> (tempType,tempNullable));
                }
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("Failed to load database scheme");
            //    databaseScheme.Clear();
            //}
        }
    }
}
