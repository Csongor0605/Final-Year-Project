using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void LoadLocalDatabase() 
        {
            using (var connection = new SqliteConnection("Data Source=localDatabase.mdf"))
            {
                connection.Open();

                //Connect to database
                //Get list of clients and fields into relevent classes
                //Update list in forms
            }
        }
    }
}
