using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calcachar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str;
            int i;
            int count = 0; int c=0; int s = 0;
            Console.WriteLine( "Enter the string");
            str= Console.ReadLine();
          
            for(i=0; i<str.Length; i++) 
            {
                if( (str[i] >= 'a' && str[i] >= 'A') ||  (str[i] <= 'z' && str[i] <= 'Z') )
                {
                    count++;
                }
                

                else if(  str[i] >= '0' &&  str[i] <= '9')
                {
                    c++;
                }
                else
                {
                    s++;
                }
               
            
                
            }
            Console.WriteLine("THE NUMBER OF ALPHABETS ARE{0}", count);
            Console.WriteLine("THE NUMBER OF NUMERICAL NUMBERS ARE{0}", c);
            Console.WriteLine("THE NUMBER OF special ch aractersARE{0}", s);
        }
    }
}
