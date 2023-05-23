using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplinq
{
    internal class Emp
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Emp() { }

        public Emp(string name, string city)
        {

            Name = name;
            City = city;

        }
    }
}
