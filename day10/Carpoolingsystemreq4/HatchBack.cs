﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpoolingsystemreq4
{
    class HatchBack:Car
    {
        private bool _powerWindowsEnabled;
        public bool PowerWindowsEnabled
        {
            get { return _powerWindowsEnabled; }
            set { _powerWindowsEnabled = value; }
        }

        private bool _automaticGear;
        public bool AutomaticGear
        {
            get { return _automaticGear; }
            set { _automaticGear = value; }

        }
        public HatchBack() { }

        public HatchBack(bool powerWindowsEnabled, bool automaticGear,long id,string name) : base(id,name)
        {

            PowerWindowsEnabled = powerWindowsEnabled;
            AutomaticGear = automaticGear;
        }
        public override double CalculateDriveCost (double km)
        {
            if (_automaticGear)
                {
                return Math.Round(km * 10, 0);
                 }


            else
                
                return Math.Round(km * 12, 0);
                
        }
    }
}

          	