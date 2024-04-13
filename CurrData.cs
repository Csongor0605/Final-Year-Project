using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public static BindingList<ClientData> clientData;
        private static string connectionString = System.Windows.Forms.Application.StartupPath + "\\" + "localDB.sqlite";
        public static Dictionary<string,Tuple< string, bool>> databaseScheme = new Dictionary<string, Tuple<string,bool>>();   //Key is display name, tuple contains data type, and if it is nullable

        public static object GetFieldValue(int clientIndex,string fieldName) 
        {
            return null;
        }

        public static bool ValidateInput(string fieldName, string data)
        {
            //Implement at least some form of validation
            return true;
        }

        public static void UpdateField(int clientID,string fieldName,object newData)
        {
            if (!ValidateInput(fieldName, newData.ToString()))
                return;
            foreach (ClientData client in clientData)
            {
                if (client.Id == clientID)
                {
                    client.SetField(fieldName, newData);
                }
            }
        }

        public static void CreateDatabase() 
        {
            if (System.IO.File.Exists(connectionString))
                return;
            else
            {
                try
                {
                    SQLiteConnection.CreateFile(connectionString);

                    using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
                    {
                        con.Open();
                        SQLiteCommand command = con.CreateCommand();
                        command.CommandText =
                            "CREATE TABLE Client(" +
                            "Id INTEGER NOT NULL, " +
                            "Name NCHAR(100) NOT NULL, " +
                            "Address NCHAR(100) NULL, " +
                            "Date_Of_Birth DATE NULL, " +
                            "PRIMARY KEY(\"Id\" AUTOINCREMENT));";

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static void SaveLocalDatabase()
        {
            //string dir = System.IO.Directory.GetCurrentDirectory();
            //StreamWriter writer = new StreamWriter(path);

            //foreach (var client in clientData)
            //{
            //    foreach (Field field in client.GetAllFields())
            //    {
            //        writer.WriteLine(field.fieldName + ',' + field.GetDataAsString());
            //    }
            //    writer.WriteLine();
            //}
            //writer.Close();

            ////Craeate stream writer
            ////Loop over each client
            ////Foreach field write name and value
            ////add blank line
            ////addblank line at the end
            ///

            using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
            {
                con.Open();
                SQLiteCommand command = con.CreateCommand();
                foreach (ClientData client in clientData)
                {
                    foreach (Field field in client.GetAllFields())
                    {
                        command.CommandText = "UPDATE Client SET "+field.fieldName+"='"+field.GetData().ToString()+"' WHERE Id="+client.Id;
                        command.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
        }

        public static void LoadLocalDatabase() 
        {

            List<ClientData> tempClient = new List<ClientData>();
            List<Field> tempFields = new List<Field>();

            //string dir = System.IO.Directory.GetCurrentDirectory();

            //StreamReader reader = new StreamReader(path);
            //string line="";
            //while (!reader.EndOfStream)
            //{
            //    line=reader.ReadLine();
            //    if (line == "")
            //    {
            //        tempClient.Add(new ClientData(tempFields.ToArray()));
            //        tempFields.Clear();
            //    }
            //    else
            //    {
            //        string[] lineSplit = line.Split(',');
            //        string fieldName = lineSplit[0];
            //        string fieldValue = lineSplit[1];
            //        tempFields.Add(new Field(fieldName, fieldValue));
            //    }

            //}
            //reader.Close();
            //clientData = new BindingList<ClientData>(tempClient);


            //try
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
                }
                //Connect to database
                //Get list of clients and fields into relevent classes
                //Update list in forms

                connection.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    //throw ex;
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
                temp.Add(new Field("Id", rand.Next(100,999)));

                temp.Add(new Field("Name","New Client"));
                temp.Add(new Field("Address",null));
                temp.Add(new FieldDateTime("DateOfBirth",null));

                fields = temp.ToArray();
            }
            
            clientData.Add(new ClientData(fields));
        }

        private static void LoadDatabaseScheme(SQLiteConnection con)
        {
            //try
            //{
                SQLiteCommand command = con.CreateCommand();
                command.CommandText = "PRAGMA table_info(Client);";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tempName = (string)reader["name"];
                    string tempType = (string)reader["type"];
                    bool tempNullable = reader["notnull"].Equals(0);

                    //databaseScheme.Add(tempName.Replace('_',' '),new Tuple<string, bool> (tempType,tempNullable));
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
