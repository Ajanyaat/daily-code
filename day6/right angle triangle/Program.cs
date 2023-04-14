using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int r;
            Console.WriteLine( "Enter the rows");
            r=int.Parse( Console.ReadLine() );
            for (i=0;i<r;i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(i);
                    
                }
                Console.Write("\n");
            }
                
        }
    }
}
