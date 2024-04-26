using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Year_Project
{
    internal class UpdatedField
    {
        private int id;
        private string fieldName;
        private object newValue;
        private object oldValue;

        public UpdatedField(int id, string fieldName, object newValue, object oldValue)
        {
            this.id = id;
            this.fieldName = fieldName;
            this.newValue = newValue;
            this.oldValue = oldValue;
        }

        public int getId()
        {
            return id;
        }
        public string getFieldName()
        {
            return fieldName;
        }
        public object getValue()
        {
            return newValue;
        }

    }
}
