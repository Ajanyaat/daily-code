using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSTRONGWR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            
            int temp = 0;
            Console.WriteLine("ENTER THE NUM");
            N = int.Parse(Console.ReadLine());
            armstrongnumber(N);
        }
       public  static void armstrongnumber(int N)
        {

        

            int arm = 0;
           int  temp = N;
            while (temp > 0)
            {
                int rem = temp % 10;
                arm = arm + (rem * rem * rem);
                temp = temp / 10;
            }
            if (arm == N)
            {
                Console.WriteLine("armstrong ");
            }
            else
            {

                Console.WriteLine("Not armstrong");
            }
        }
    }
    
}
