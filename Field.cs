using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Year_Project
{
    class Field
    {
        public string fieldName;
        protected object data;

        public Field(string fieldName, object data)
        {
            this.fieldName = fieldName;
            this.data = data;
        }

        public object GetData() { return data; }
    }

    class FieldDateTime: Field 
    {
        private new DateTime data;

        public FieldDateTime(string fieldName, object data) : base(fieldName, data)
        {
            try
            {
                this.data = Convert.ToDateTime(data);
            }
            catch 
            {
                this.data = new DateTime();
            }
            this.fieldName = fieldName;
        }
    }
}
