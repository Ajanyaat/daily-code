using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("*****************");
                Console.WriteLine("1.Enter the account details");
                Console.WriteLine("2.Display the information");
                Console.WriteLine("3.Deposit Amount");
                Console.WriteLine("4.Withdraw Amount");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter the Choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)

                {
                    case 1:
                        Console.WriteLine("Enter the Account ID");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        String Name = Console.ReadLine();
                        Console.WriteLine("Enter opening Balance");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(ID,Name, Balance);
                        break;
                    case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else
                            Console.WriteLine(" *******Open Account First***** \n");
                        break;
                    case 3:
                        if (a != null)
                            a.DepositInfo(5000);
                        else
                            Console.WriteLine("*******Open Account First*****\n");
                        break;
                    case 4:
                        if (a != null)
                            a.WithdrawInfo(5000);
                        else
                            Console.WriteLine("*******Open Account First****\n");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wronf Choice \n");
                        break;
                }
            } while (ch != 0);
            Console.WriteLine("***Thanks for using Bank Operations*** \n");



                }

                    
                


            }
            

        }
    

