using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace carpoolingsystemreq5
{
    internal class Customer
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string Lastname
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }

        }
        private string _license;
        public string License
        {
            get { return _license; }
            set { _license = value; }
        }
        private DateTime _licenseStartDate;
        public DateTime LicenseStartDate
        {
            get { return _licenseStartDate; }
            set { _licenseStartDate = value; }
        }
        private DateTime _licenseEndDate;
        public DateTime _licenseExpiryDate
        {
            get { return _licenseExpiryDate; }
            set { _licenseExpiryDate = value; }
        }
        public Customer()
        {

        }
        public Customer(long _id, string _firstName, string _lastName, string _email, string _contactNumber, string _license
          )
        {
            Id = _id;
            FirstName = _firstName;
            Lastname = _lastName;
            Email = _email;
            ContactNumber = _contactNumber;
            License = _license;
           

        }
        public override string ToString()
        {
            return string.Format(" firstname{0}\n lastname{1},email{2}\n contactNumber{3}\n ",
                FirstName, Lastname, Email, ContactNumber);
        }

        public void validemail(string email)
        {
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                throw new InvalidEmailException(email);

            }



        }
    }
}
