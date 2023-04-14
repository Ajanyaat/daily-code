using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
     class shape

    {
       public virtual void Drawshape()
        {
            Console.WriteLine( "Drawing shapes");
        }

    }
    class Circle:shape { 
        public  override void Drawshape() {
            Console.WriteLine( "Drawing circle");
        }
    }
    class Rectangle : shape
    {
        public  override void Drawshape() {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
