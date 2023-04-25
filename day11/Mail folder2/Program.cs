using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_folder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail>ls=new List<Mail>();
            
            Console.WriteLine("Enter the folder name");
            string Name=Console.ReadLine();
            Mail m= new Mail();
            MailFolder mf = new MailFolder(Name,ls);
            while(true)
            {
                Console.WriteLine("enter a choice\n 1-Addmail\n 2-Remove mail\n 3-Display mail\n 4-Exit");
                int a=int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("enter the details");
                        string details = Console.ReadLine();
                        m = Mail.CreateMail(details);
                        mf.AddMailToFolder(m);
                        Console.WriteLine("mail added successfully");
                        break;
                    case 2:
                        Console.WriteLine("enter the id to be deleted");
                        int id = int.Parse(Console.ReadLine());
                        mf.RemoveMailFromFolder(id);
                        break;
                    case 3:
                        mf.DisplayMails();
                        break;
                }
                }
            }
           


            
               
            }

        } 

