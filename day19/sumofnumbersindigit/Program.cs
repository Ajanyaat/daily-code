using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofnumbersindigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            int Num;
            int rev;
            Console.WriteLine("enter a num");
            Num = int.Parse(Console.ReadLine());
            while (Num != 0)
            {
                rev = Num % 10;
                Num = (Num / 10);
                sum = sum + rev;

            }
            Console.WriteLine(sum);

        }
    }
}
