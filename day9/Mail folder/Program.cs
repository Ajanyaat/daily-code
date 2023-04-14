using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_folder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter the mail 1 detail");
            Mail m1 = new Mail();
            string input=Console.ReadLine();
            String[] inputs = input.Split(',');
            int input1 = int.Parse(inputs[0]);
            string input2 = inputs[1];
            string input3 = inputs[2];
            string input4 = inputs[3];
            string input5 = inputs[4];
            DateTime input6= DateTime.Parse(inputs[5]);
            double input7= double.Parse(inputs[6]);
            Console.WriteLine("Mail 1");


            Console.WriteLine("Enter the mail 2 details");
            Mail m2= new Mail();
            string inpt = Console.ReadLine();
            String[] inpts = input.Split(',');
            int inpt1 = int.Parse(inputs[0]);
            string inpt2 = inputs[1];
            string inpt3 = inputs[2];
            string inpt4 = inputs[3];
            string inpt5 = inputs[4];
            DateTime inpt6 = DateTime.Parse(inputs[5]);
            double inpt7 = double.Parse(inputs[6]);
            Console.WriteLine("Mail 2");



            Console.WriteLine(m1);
            string[] spts = input.Split(',');
            foreach(string s in spts)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(m2);
            string[] sptjs = input.Split();
            foreach(string s in spts)
            {





                Console.WriteLine(s);
            }
            if (m1.Equals(m2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }


 
        }
    }
}
