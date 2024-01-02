using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Final_Year_Project
{
    internal static class CurrData
    {
        public static ClientData[] clientData;

        public static object GetFieldValue(int clientIndex,string fieldName) 
        {
            return null;
        }

        public static void CreateDatabase(string dbName = "localDB.db") 
        {
            
        }

        public static void LoadLocalDatabase() 
        {
            //try
            //{
                using (var connection = new SQLiteConnection("Data Source=Final_Year_Project.Properties.Settings.localDatabaseConnectionString"))
                {
                    connection.Open();
                    
                    
                    SQLiteCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Client";
                    var reader = command.ExecuteReader();

                    List<ClientData> tempClient = new List<ClientData>();
                    while (reader.Read())
                    {
                        List<Field> tempFields = new List<Field>();
                        for (int i =0; i < reader.VisibleFieldCount;i++)
                        {
                            string type = reader.GetFieldType(i).ToString();
                            switch (type)
                            {
                                case "System.DateTime":
                                    tempFields.Add(new FieldDateTime(reader.GetName(i), reader.GetValue(0)));
                                    break;
                                default:
                                    tempFields.Add(new Field(reader.GetName(i), reader.GetValue(0)));
                                    break;
                            }
                        }
                        tempClient.Add(new ClientData(tempFields.ToArray()));
                    }
                    clientData = tempClient.ToArray();
                    //Connect to database
                    //Get list of clients and fields into relevent classes
                    //Update list in forms

                    //connection.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //    //Handle this in some way
            //}
        }
    }
}
