using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicequestion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter ea number");
            n =int.Parse(Console.ReadLine());
            if (IsPowerOf2(n))
            {
                Console.WriteLine($"{ n} is  power of 2");
            }
            else
            {
                Console.WriteLine($"{n} is not  power of 2");
            }
           
        }
        static bool IsPowerOf2(int n)
        {
            if (n <= 0)
                return false;
            while(n%2== 0)
            {
                n /= 2;
            }
            return n == 1;

            
        }

    }
}
