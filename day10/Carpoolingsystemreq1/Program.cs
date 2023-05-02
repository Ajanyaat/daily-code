using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Carpoolingsystemreq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>();
            for (int i =0 ; i < 2; i++)
            {

                Console.WriteLine("Member{0}", i + 1);
                Console.WriteLine("Id");
                long id = long.Parse(Console.ReadLine());
                Console.WriteLine("First Name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Last Name");
                string lastname = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Contact Number");
                string contactno = Console.ReadLine();
                Console.WriteLine("licence number");
                string licence = Console.ReadLine();
                Console.WriteLine("license start date");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                Console.WriteLine("license end date");
                DateTime dt2 = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                Member m1 = new Member(id, firstname, lastname, email, contactno, licence, dt1, dt2);
                list.Add(m1);
            }
            int j = 1;
            foreach(var item in list)
            {
                Console.WriteLine("Member{0}",j);
                Console.WriteLine(item.ToString());
                j++;
            }


            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("member 1 is same as member 2");
            }
            else
            {
                Console.WriteLine("member 1 and member 2  are different");
            }



        }

        }
    
}
