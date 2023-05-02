using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteandReader
{
    internal class Program
    {
        class WriteandReader
        {

            static string file = @"D:\\ust demos\example.txt";
            static void Main()
            {
                Write();
                // Read();
            }
            static void Write()
            {
                StreamWriter filestream = new StreamWriter(file);
                filestream.WriteLine("What is this life");
                filestream.WriteLine("we have no time to nstand and stare");
                filestream.Close();
            }



        }





    }
}
