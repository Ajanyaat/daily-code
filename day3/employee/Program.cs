using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            emp e1 = new emp();
            emp e2 = new emp2();

            Console.WriteLine( "Enter emoloyee id:");
            e1.empid=int.Parse(Console.ReadLine());
            Console.WriteLine( "Enter employee name");
            e1.empname=Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            e1.Salary=Decimal.Parse(Console.ReadLine());

        }
    }
}
