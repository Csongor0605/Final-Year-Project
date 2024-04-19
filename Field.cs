using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Final_Year_Project
{
    //"NCHAR(100)", "INTEGER", "DATE","DATETIME", "TEXT", "REAL"
    //^List of types of field
    public class Field
    {
        public string fieldName; //Field name to disply, not as in database
        protected object data;

        public Field(string fieldName, object data)
        {
            this.fieldName = fieldName;
            this.data = data;
        }

        public object GetData() { return data; }

        public string GetDataAsString()
        {
            if (data == null)
                return "";
            return data.ToString();
        }

        public void SetData(object data)
        {
            this.data = data;
        }
    }

    class FieldShortString : Field
    {
        private new string data;

        public FieldShortString(string fieldName, object data) : base(fieldName, data)
        {
            SetData(data);
            this.fieldName=fieldName;
        }

        public new void SetData(object data)
        {
            this.data = data.ToString();
        }
    }

    class FieldInteger: Field
    { 
        private new int data;

        public FieldInteger(string fieldName, object data) : base(fieldName, data)
        { 
        
        }

        public new void SetData(object data) 
        { 
            this.data = (int)data;
        }
    }


    class FieldDateTime: Field 
    {
        private new DateTime data;

        public FieldDateTime(string fieldName, object data) : base(fieldName, data)
        {
            SetData(data);
            this.fieldName = fieldName;
        }

        public new string GetDataAsString() 
        {
            if (data == null)
                return "";
            return data.ToShortDateString();
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = Convert.ToDateTime(data);
            }
            catch
            {
                //Add better handling, this is not good
                this.data = new DateTime();
            }
        }
    }

    
}
