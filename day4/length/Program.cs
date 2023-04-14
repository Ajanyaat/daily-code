using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l=0;
            String str;
            Console.WriteLine( "enter the string");
            str = Console.ReadLine();
            
            foreach(char chr in str)
            {
                l=l+1;
            }

            Console.WriteLine("The length of the string is{0}", l);


        }

    }
}
