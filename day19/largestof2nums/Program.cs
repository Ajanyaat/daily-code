using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestof2nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            
            Console.WriteLine( "enter num1");
            num1=int.Parse( Console.ReadLine() );
           
            if(num1%2==0) { Console.WriteLine("num1 is divisible"); }
            else { Console.WriteLine("num2 is not divisible"); }
        }
    }
}
