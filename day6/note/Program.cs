using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int amount;
            int number;
            int r;
            Console.WriteLine( "Enter the amount");
            amount=int.Parse( Console.ReadLine() );

            
            number =amount / 2000;
            r = amount % 2000;

            

            Console.WriteLine("2000 rupees notes are {0}", number);
            number = r / 500;
            r=r%500;
            Console.WriteLine("500  rupees notes are {0}", number);
            number = r / 100;
            r=r%100;
            Console.WriteLine( "100 rupees notes are {0}", number);
            number = r / 50;
            r=r%50;
            Console.WriteLine( "50 rupees notes are {0}" , number);
            number = r /10 ;
            r = r %10 ;
            Console.WriteLine( "10 rupees notes are {0}",number);
            number = r / 5;
            r = r % 5;
            Console.WriteLine("5 rupees notes are {0}", number);





        }
    }
}
