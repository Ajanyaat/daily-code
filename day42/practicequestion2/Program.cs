using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practicequestion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s=Console.ReadLine();
            string s1 = Regex.Replace(s, @"(?i)\b(\w+)(\s+\1)+\b", "$1");
            Console.WriteLine(s1);
        }
    }
}
