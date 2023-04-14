using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace menu
{
    public class Account
    {
        public int ID;
        private string _name;
        public String Name
        {
            get { return _name; }
            set {
                if (_name.Length > 15)
                    throw new Exception("Name too long");
                _name = value; 
            }

        }
       
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }

        }

        public void CreateAccount(int id, string name, decimal balance)
        {
            ID = id;
            Name = name;
            
            
            
            Balance = balance;
        }
        public override string ToString()
        {
            string str = "";
            str += "Id:" + ID;
            str += "Name:" + Name;
            int += "Balance:" + Balance;
        }

        public void DisplayInfo()
        { Console.WriteLine("***Account Information");
            Console.WriteLine("Account Id:" + ID);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance:" + Balance);
        }
        public void DepositInfo(decimal amount)
        {




            Balance += amount;
        }
        public void WithdrawInfo(decimal amount)
        {
            if (Balance - amount < 500)

                Console.WriteLine("Insufficient Balance");

            else
                this.Balance = amount;
        }
        }
    }