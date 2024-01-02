using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Year_Project
{
    internal class ClientData
    {
        public string displayName = "NoDisplayName";
        private Dictionary<string, Field> fields;

        public ClientData(Field[] fields)
        {
            this.fields = new Dictionary<string, Field>();
            foreach (Field currField in fields) 
            {
                this.fields.Add(currField.fieldName, currField);
                if (currField.fieldName == "Name")
                {
                    displayName = currField.GetData().ToString();
                }
            }
        }

        public object GetFieldData(string fieldName)
        {
            //TODO
            return null;
        }
    }
}
