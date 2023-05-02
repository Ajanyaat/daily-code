using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap2numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter n");
            n = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("enter k");
            int k;
            k=int.Parse(Console.ReadLine());
            int[] arr=new int[10];

            Console.WriteLine("enter elements");
            for (i = 0; i < n;i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("print the array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (i = 0; i < n; i++)
            {
                if (arr[i] == k)
                {
                    Console.WriteLine("index={0}", i);
                }
                else { Console.WriteLine("1"); }

            }
          



        }
    }
}
