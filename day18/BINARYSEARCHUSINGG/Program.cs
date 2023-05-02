using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BINARYSEARCHUSINGG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("enter the number of elements");
            

            n= int.Parse(Console.ReadLine());
            int k;
            Console.WriteLine("enter k");
            k= int.Parse(Console.ReadLine());   
            int[] arr = new int[n];
            Console.WriteLine("enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int b = binarynumber(arr, n, k);
            Console.WriteLine("{0}", b);
        }
        public static int binarynumber(int[] arr, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == k)
                {
                    return i;
                }

            }

            return 0;
        }

    }
}