using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carpoolingsystemreq4
{
    public  class Sedan:Car
    {
        private bool _absEnabled;
        public bool AbsEnabled
        {
            get { return _absEnabled; }
            set { _absEnabled = value; }
        }




        private Int32 _bootSpace;
        public Int32 BootSpace
        {
            get { return _bootSpace; }
            set { _bootSpace = value; }
        }
        public Sedan()
        {
        }
        public Sedan( bool absEnabled, int bootSpace,long id,string name): base(id, name)
        {
           
            AbsEnabled = absEnabled;
            BootSpace = bootSpace;
           
        }
        public override double CalculateDriveCost(double km)
        {
            return Math.Round(km*15,0);
        }
    }
}
