using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Square();
            fig.Dimension = 10;
            Console.WriteLine( fig.area());
            Console.WriteLine( fig.Perimeter());




            Figure fig1 = new Circle();
            {
                fig1.Dimension = 10;
                Console.WriteLine( fig1.area());
                Console.WriteLine( fig1.Perimeter());

            }
        }
    }
}
