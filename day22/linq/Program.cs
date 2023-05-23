﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rose", "lotus", "lily", "hibiscus", "daffodil" };
            var fquery = from flower in flowers
                         
                         where (flower.StartsWith("d"))
                         select flower;

            foreach(string f in fquery)
            {
                Console.WriteLine(f);
            }
        }
    }
}