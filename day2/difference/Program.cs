using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the value");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine(difference(n,51));

        }
        static int difference(int n, int K)
        {



            if (n > K)
            {

                return (n - K) * 3;


            }

            else
            {
                return n;
            }
           
          


         }
        
    }
}
