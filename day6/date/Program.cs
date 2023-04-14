using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2016, 8, 15, 7, 8, 0);
               Console.WriteLine("complete date:"+dt1.ToString());
            DateTime dateOnly = dt1.Date;
            Console.WriteLine( "short date:" + dateOnly.ToString("d"));
            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }
    }
}
