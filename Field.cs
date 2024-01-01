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

        public object GetData() { return data; }
    }

    class FieldDateTime: Field 
    {
        private new DateTime data;

    }
}
