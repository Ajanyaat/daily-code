using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carpoolingsystemreq4
{
   public  class UtilityCar:Car
    {
        private bool _rearCoolingVents;
        public bool RearCoolingVents
        {
            get { return _rearCoolingVents; }
            set { _rearCoolingVents= value; }
        }
        public UtilityCar() { }

        public UtilityCar(bool rearCoolingVents,long id,string name) : base(id, name)
        {
            RearCoolingVents = rearCoolingVents;
            
        }
        public override double CalculateDriveCost(double km)
        {
            return Math.Round(km*18,0);
        }
    }

}
