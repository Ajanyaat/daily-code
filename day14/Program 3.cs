using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascendingorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int temp=0;
            int i;
            
            int[] arr = { 1,0,2,1,2 };
            for( i=0;i<arr.Length;i++)
            {
                for(int j=i;j<arr.Length;j++)
                {
                    if (arr[j ] < arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i ] = temp;
                    }
                }
                Console.WriteLine(arr[i]);

            }
            
        }
    }
}
