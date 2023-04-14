using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Figure
    {
        public int Dimension;
        public abstract double area();
        public abstract double Perimeter();
    }


    class Square : Figure
    {
    public override double area()
    {
        return Dimension * Dimension;

    }
    public override double Perimeter()
    {
            return 4 * Dimension;
    }


    }
    class Circle : Figure
    {
        public override double area()
        {
            return Math.PI * Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Dimension;
        }
    }






}





