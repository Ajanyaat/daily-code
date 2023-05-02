using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            {
                s.Add("Maharashtra", "Mumbai");
                s.Add("Chennai", "TamilNadu");
                s.Add("Kochi", "Kerala");
                s.Add("Maharashtra", "Mumbai");
                s.Add("Rajastan", "Jaipur");
                s.Add("Orissa", "Hyderabad");

                IDictionaryEnumerator e = s.GetEnumerator();

                while (e.MoveNext())
                {
                    Console.WriteLine(e.Key + "\t" + e.Value);
                }


            }
            foreach (var item in s.Keys)
            {
                Console.WriteLine(s);
            }
        }
    }
}
