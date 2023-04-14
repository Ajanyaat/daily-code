using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 0; int t=0;int s;
            Console.WriteLine("Enter the distance");
            d=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            t=int.Parse(Console.ReadLine());
            s=speed(d,t);
            Console.WriteLine("The speed is {0}",s);
            Console.WriteLine( "The ");

        }
        static int speed(int d,int t)
        {
            int s = 0;
            s=d*t;
            return s;
        }
    }
}
