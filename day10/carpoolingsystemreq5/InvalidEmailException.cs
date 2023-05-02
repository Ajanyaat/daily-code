using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpoolingsystemreq5
{
    internal class InvalidEmailException:Exception
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public InvalidEmailException(string email)
        {
           Email = email;
        }
        public void inform()
        {
            Console.WriteLine("InvalidEmailException");
        }
    }
}
