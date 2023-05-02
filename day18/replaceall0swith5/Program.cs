using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace replaceall0swith5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c;
            Console.WriteLine("enter n");
            n=int.Parse(Console.ReadLine());

            c = convertfive(n);
            Console.WriteLine("The converted num is {0}", c);
        }
        public static int convertfive (int n)
        {
            int copy = n;
            int multiplier = 1;
            while (n > 0)
            {
                int digit =n % 10;
                if (digit == 0)
                {
                    copy = copy + (multiplier * 5);

                }
                multiplier = multiplier * 10;
                n = n / 10;
            }
            return copy;
        }
    }
}
