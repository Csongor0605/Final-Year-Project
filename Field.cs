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
            SetData(data);
            this.fieldName=fieldName;
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = int.Parse(data.ToString());
            }
            catch (Exception e) { throw e; }
        }
    }

    class FieldDate : Field 
    {
        private new DateTime data;

        public FieldDate(string fieldName, object data) : base(fieldName, data)
        {
            SetData(data);
        }

        public new string GetDataAsString()
        {
            if (data == null)
                return "";
            return data.Date.ToShortDateString();
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = Convert.ToDateTime(data).Date;
            }
            catch
            {
                //Add better handling, this is not good
                this.data = new DateTime();
            }
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

    class FieldLongString:Field
    { 
        private new string data;
        public FieldLongString(string fieldName, object data) : base(fieldName, data)
        {
            SetData(data);
            this.fieldName = fieldName;
        }

        public new void SetData(object data)
        {
            this.data = data.ToString();
        }
    }

    class FieldReal : Field
    { 
        private new float data;
        public FieldReal(string fieldName, object data) : base(fieldName, data)
        {
            SetData(data);
            this.fieldName = fieldName;
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = float.Parse(data.ToString());
            }
            catch (Exception e) { throw e; }//Should be handled better but this works for current development
        }
    }
}
