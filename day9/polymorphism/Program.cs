using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                shape s1 = new shape();
                s1.Drawshape();
                Circle c1 = new Circle();
                c1.Drawshape();
                Rectangle r1 = new Rectangle();
                r1.Drawshape();


                shape s2 = new Circle(); //upcasting 
                s2.Drawshape();
                shape s3 = new Rectangle();
                s3.Drawshape();
            //Array of referencesof base
            //
            //
            //
            //
            //
            //class referencing 
            //Derived class






             shape t= null;
             Console.WriteLine("Enter shape:"); 
             string shape= Console.ReadLine();
             if(shape.ToLower() =="circle")
            {
                t = new Circle();
            }
             else if(shape.ToLower() == "rectangle")
            {
                t = new Rectangle();
            }

        }
    }
}
