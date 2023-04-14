using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2016, 7, 11);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
        
    }
    }
}
