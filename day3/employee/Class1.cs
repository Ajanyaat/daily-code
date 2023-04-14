using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class emp
    {
        private int Empid;
        private string Empname;
        public double Salary;

    }
    public emp()
    {
    }
    public emp(int empid, string empname, decimal salary)
    {
        Empid = empid;
        Empname = empname;
        salary = salary;
    }


}

