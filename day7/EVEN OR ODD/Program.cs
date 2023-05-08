using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEN_OR_ODD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("ENTER A NUM");
            a=int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }
    }
}
