using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace debugging_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine( "Enter Second Num");


            int j=int.Parse(Console.ReadLine());
            foo(i, i);
            Console.WriteLine("Debugging over");
          
        }
        public static void foo(int x,int y)
        {
            int t = 100;
              for(int i=x;i<=y;i++)
            { 
                Console.WriteLine( "India");
                 t = t + 2;
                }
        }

    }
}
