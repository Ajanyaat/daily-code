using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> Employeelist = new List<Emp>();
            Employeelist.Add(new Emp("ram", "hyd"));
            Employeelist.Add(new Emp("sam", "mum"));
            Employeelist.Add(new Emp("jan", "delhi"));
            Employeelist.Add(new Emp("aadhi", "kol"));
            Employeelist.Add(new Emp("sunil", "kol"));
            Employeelist.Add(new Emp("sonu", "trv"));
            Employeelist.Add(new Emp("arohi", "kochi"));
            Employeelist.Add(new Emp("honey", "trs"));


            var Empquery = from Emp emp in Employeelist
                           orderby emp.City
                           group emp by emp.City;
            foreach (var e in Empquery)
            {
                Console.WriteLine("Employee with" + e.Key + "City");


                foreach (var name in e)
                {
                    Console.WriteLine(" " + name.Name);
                }
            }



        }  


        
    }
}
