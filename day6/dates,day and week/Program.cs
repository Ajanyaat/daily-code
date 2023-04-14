using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dates_day_and_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine( dt);
            Console.WriteLine( dt.ToString());//print the date
            DateTime dt1=DateTime.Now;// 
            Console.WriteLine( dt1.ToString());
            DateTime dt2 = DateTime.(12, 3, 2022);
            Console.WriteLine( dt2.ToString()); 
        }
    }
}
