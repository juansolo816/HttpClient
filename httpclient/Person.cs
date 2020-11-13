using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace httpclient
{
    public class Person
    {
        private int id;
        private string name;

        public int ID
        {
            get { return id; }
            set { id = value; } // Note: "value" is a special built-in keyword of properties.
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        
            
    }
}
