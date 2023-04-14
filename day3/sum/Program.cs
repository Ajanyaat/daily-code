
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 0; int b=0; int s;
            Console.WriteLine("Enter the first element");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first element");
            b=int.Parse(Console.ReadLine());
            s = sum(a, b);
            Console.WriteLine("Sum of 2 numbers is{0}", s);
        }
        static int sum(int a, int b)

        {
            int s = 0;
            s = a + b;
           
            if(a==b)
            {
                return s * 3;
            }
            else
            {
                return s;
            }
        }
      
    }
}
