using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqextension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome to Dotnet Tutorials";

            int wordCount = s.GetWordCount();
            Console.WriteLine($"Count : {wordCount}");
            Console.ReadKey();
        }

        
    }
}
