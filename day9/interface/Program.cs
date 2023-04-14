
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine( "Enter 'C' for circle or 'S' for square");
            string ch= Console.ReadLine();
            if (ch == "S")
            {
                fig = new Square(); // creating object of square class
            }
            else if (ch == "C")
            {
                fig = new Circle();
            }



            fig.Dimension = 10;
            Console.WriteLine( fig.Area());
            Console.WriteLine( fig.Perimeter());
        }

    }
}
