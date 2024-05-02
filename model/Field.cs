using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Final_Year_Project
{
    //"NCHAR(100)", "INTEGER", "DATE","DATETIME", "TEXT", "REAL"
    //^List of types of field
    public class Field
    {
        public string fieldName; //Field name to disply, not as in database, should be converted each way in CurrData
        protected object data;
        protected bool blank = true;

        public Field(string fieldName, object data)
        {
            this.fieldName = fieldName;
            this.data = data;
        }

        public object GetData() { return data; }

        public string GetDataAsString()
        {
            if (blank)
                return "";
            return data.ToString();
        }

        public void SetData(object data)
        {
            if (data != null)
            {
                this.data = data;
                blank = false;
            }
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
            string temp  = data.ToString();
            if (!(temp.Length >= 100))
            {
                this.data = data.ToString();
                blank = false;
            }
            
        }
    }

    class FieldInteger: Field
    { 
        private new long data;

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
                blank = false;
            }
            catch (Exception e) { blank = true; }
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
            if (blank)
                return "";
            return data.ToString("yyyy-MM-dd");
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = Convert.ToDateTime(data).Date;
                blank = false;
            }
            catch
            {
                //Add better handling, this is not good
                blank = true;
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
            if (blank)
                return "";
            return data.ToString("yyyy-MM-dd HH:mm");
        }

        public new void SetData(object data)
        {
            try
            {
                this.data = Convert.ToDateTime(data);
                blank = false;
            }
            catch
            {
                //Add better handling, this is not good
                blank = true;
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
                blank = false;
            }
            catch (Exception e) { blank = true; }//Should be handled better but this works for current development
        }
    }
}
