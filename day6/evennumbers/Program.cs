using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evennumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum=0;
            for(i=1;i<100;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("{0}",sum);
        }
    }
}
