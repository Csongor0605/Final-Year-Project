using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Year_Project
{
    internal class ClientData
    {
        public readonly int Id;
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
                else if (currField.fieldName == "Id")
                {
                    int.TryParse(currField.GetData().ToString(),out Id);
                }
            }
        }

        public object GetFieldData(string fieldName)
        {
            //TODO
            return null;
        }

        public Field[] GetAllFields()
        {
            return fields.Values.ToArray();
        }

        public override string ToString()
        {
            return displayName;
        }

        public void SetField(string fieldName, object data)
        {
            fields[fieldName].SetData(data);
            if (fieldName == "Name")
            {
                displayName = data.ToString();
            }
        }

    }
}
