using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int m;
            int num;
            Console.WriteLine( "Enter a number");
            i=int.Parse(Console.ReadLine() );
            
            for(i=0;i<=10;i++)
            {

                m = i * 2;
               
                Console.WriteLine("{0}*{1} ={2}",i, 2,m  ); 
            }
            
        }
    }
}
