using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=5;
            int s=0;
            int sum;
            int mn;
            int[] arr = {1,2,3,5};

            sum = (N * (N + 1)) / 2;
            for(int i=0;i<arr.Length;i++)
            {
                s +=arr[i];
            }
            mn = sum- s;
            Console.WriteLine("Missing number is {0}",mn);
        }
    }
}
