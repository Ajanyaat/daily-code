using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3, 25, 61, 2, 3 };
            int n = arr.Length;
            int i;
            Console.Write($" ==> {arr[i]}");
            for ( i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }


            for (i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

        }

    }
}

