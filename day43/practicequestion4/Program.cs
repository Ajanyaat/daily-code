using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicequestion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of elements");
            n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter elements");
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}
