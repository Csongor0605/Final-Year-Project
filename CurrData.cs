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

namespace Final_Year_Project
{
    internal static class CurrData
    {
        public static BindingList<ClientData> clientData;
        private static string connectionString;

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

        public static void CreateDatabase(string dbName = "localDB.db") 
        {
            //string conString = @"URI=file:" + System.Windows.Forms.Application.StartupPath + "\\" + dbName;
            //using (SQLiteConnection con = new SQLiteConnection(conString))
            //{
            //    con.Open();
            //    SQLiteCommand command = con.CreateCommand();
            //    command.CommandText = 
            //        "CREATE TABLE [dbo].[Client](" +
            //        "[Id] INT NOT NULL, " +
            //        "[Name] NCHAR(100) NOT NULL, " +
            //        "[Address] NCHAR(100) NULL, " +
            //        "[DateOfBirth] DATE NULL, " +
            //        "PRIMARY KEY CLUSTERED([Id] ASC) );";

            //    command.ExecuteNonQuery();
            //}
        }

        public static void SaveLocalDatabase(string path = @"C:\Users\Me\source\repos\Final-Year-Project\default.csv")
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            StreamWriter writer = new StreamWriter(path);
            
            foreach (var client in clientData) 
            {
                foreach (Field field in client.GetAllFields())
                {
                    writer.WriteLine(field.fieldName + ',' + field.GetDataAsString());
                }
                writer.WriteLine();
            }
            writer.Close();
            //Craeate stream writer
            //Loop over each client
            //Foreach field write name and value
            //add blank line
            //addblank line at the end
        }

        public static void LoadLocalDatabase(string path= @"C:\Users\Me\source\repos\Final-Year-Project\default.csv") 
        {
            
            List<ClientData> tempClient = new List<ClientData>();
            List<Field> tempFields = new List<Field>();

            string dir = System.IO.Directory.GetCurrentDirectory();

            StreamReader reader = new StreamReader(path);
            string line="";
            while (!reader.EndOfStream)
            {
                line=reader.ReadLine();
                if (line == "")
                {
                    tempClient.Add(new ClientData(tempFields.ToArray()));
                    tempFields.Clear();
                }
                else
                {
                    string[] lineSplit = line.Split(',');
                    string fieldName = lineSplit[0];
                    string fieldValue = lineSplit[1];
                    tempFields.Add(new Field(fieldName, fieldValue));
                }
                
            }
            reader.Close();
            clientData = new BindingList<ClientData>(tempClient);



            //try
            //{
            //using (var connection = new SQLiteConnection("Data Source=Final_Year_Project.Properties.Settings.localDatabaseConnectionString"))
            //{
            //    connection.Open();


            //    SQLiteCommand command = connection.CreateCommand();
            //    command.CommandText = "SELECT * FROM Client";
            //    var reader = command.ExecuteReader();

            //    List<ClientData> tempClient = new List<ClientData>();
            //    while (reader.Read())
            //    {
            //        List<Field> tempFields = new List<Field>();
            //        for (int i =0; i < reader.VisibleFieldCount;i++)
            //        {
            //            string type = reader.GetFieldType(i).ToString();
            //            switch (type)
            //            {
            //                case "System.DateTime":
            //                    tempFields.Add(new FieldDateTime(reader.GetName(i), reader.GetValue(0)));
            //                    break;
            //                default:
            //                    tempFields.Add(new Field(reader.GetName(i), reader.GetValue(0)));
            //                    break;
            //            }
            //        }
            //        tempClient.Add(new ClientData(tempFields.ToArray()));
            //    }
            //    clientData = tempClient.ToArray();
            //Connect to database
            //Get list of clients and fields into relevent classes
            //Update list in forms

            //connection.Close();
            //}
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //    //Handle this in some way
            //}
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
                temp.Add(new FieldDateTime("Date of Birth",null));

                fields = temp.ToArray();
            }
            
            clientData.Add(new ClientData(fields));
        }
    }
}
