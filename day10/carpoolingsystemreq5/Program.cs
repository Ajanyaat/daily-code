using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpoolingsystemreq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Customer> list = new List<Customer>();
            int num;
            Console.WriteLine("enter the numbers of members");
            num=int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Enter Member {0}", i + 1);
                string[] s = Console.ReadLine().Split(',');
                Customer m1 = new Customer(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5]);
                list.Add(m1);


                try
                {
                    m1.validemail(s[3]);

                }
                catch(InvalidEmailException e)
                {
                    e.inform();

                }
            }
        
            
        }
    }
}
