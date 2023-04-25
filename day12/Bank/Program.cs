using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Rahul", 2453, 500);
            try
            {
                c.withdraw(450);

            }
            catch(bankexception e)
            {
                Console.WriteLine("Transaction Failed");
                e.inform();
            }
        }
    }
}
