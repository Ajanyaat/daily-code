using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace telephone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrophone e1 = new Electrophone();
            e1.run();
        }
        class Telephone
        {



            protected string _phonetype;
            public string Phonetype
            {
                get { return _phonetype; }
                set { _phonetype = value; }
            }

            public Telephone() { }  

            public Telephone(string phonetype)
            {
                _phonetype = phonetype;

            }
            public void ring()
            {
                Console.WriteLine("Ringing the "+Phonetype  );
            }



        }
        class Electrophone : Telephone
        {
            private int _digital;
            public int Digital {

                get { return _digital; }
                set { _digital = value; }   

            } 

            public Electrophone() { }  
            public Electrophone(string phonetype)
            {
                phonetype = "Digital"; 
            }
            public 
                    void run()
            {
                ring();


            }


        }




    }
}
