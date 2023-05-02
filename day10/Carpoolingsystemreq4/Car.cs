using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpoolingsystemreq4
{
    public abstract  class Car
    {
        protected long _id;
        public long Id { get { return _id; } set { _id = value; } }

        protected string _name;
        public string Name { get { return _name; } set { _name = value; } }

        
        public Car()
        {
        }

        public Car(long _id, string _name)
        {
            Id = _id;
            Name = _name;
            
        }
        public abstract double CalculateDriveCost(double km);










}
}
