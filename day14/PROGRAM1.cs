using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
              int[] arr = { 1, 2, 3, 7, 5 };
                int n = arr.Length;
                int sum = 12;
                subArraySum(arr, n, sum);
            }
            void subArraySum(int[] arr, int n, int sum)
            {
                for (int i = 0; i < n; i++)
                {
                    int currentSum = arr[i];

                    if (currentSum == sum)
                    {
                        Console.WriteLine(" indexe " + i);
                        return;
                    }
                    else
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            currentSum += arr[j];

                            if (currentSum == sum)
                            {
                                Console.WriteLine(" indexes " + (i + 1) + " and " + (j + 1));
                                return;
                            }
                        }
                    }
                }
                Console.WriteLine("No subarray found");
                return;
            }
        }
    }
}
                
                
            

    

