using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int temp = 0;
            Console.WriteLine("ENTER THE NUM");
            N = int.Parse(Console.ReadLine());
       
            
            int arm = 0;
            temp = N;
            while( temp> 0)
            {
                int rem = temp% 10;
                arm = arm + (rem * rem * rem);
                temp=temp / 10;
            }
            if(arm==N)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("Not armstrong");
            }
        }
    }
}
