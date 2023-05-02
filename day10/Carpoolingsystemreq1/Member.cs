using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carpoolingsystemreq1
{
    internal class Member
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
        public Member()
        {

            }
        public Member(long _id, string _firstName, string _lastName, string _email, string _contactNumber, string _license
            , DateTime _licenseStartDate, DateTime _licenseEndDate)
        {
            Id= _id;
            FirstName= _firstName;
            Lastname= _lastName;
            Email= _email;
            ContactNumber= _contactNumber;
            License= _license;
            LicenseStartDate= _licenseStartDate;
            LicenseStartDate = _licenseEndDate;

        }
        public override string ToString()
        {
            return string.Format("Name:{0},{1}:\n Member Contact Details:{2},{3}",
                FirstName, Lastname, Email, ContactNumber);




                
        }




        public override bool Equals(object obj)
        {
            Member m1 = obj as Member;
            if (m1.Email ==Email && m1.ContactNumber ==ContactNumber )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
