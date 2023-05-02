using CarpoolingExcercisereq6;
using CarPoolingReq6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingExcercisereq6
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

        public string LastName

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

        private string _licenseNumber;

        public string LicenseNumber

        {

            get { return _licenseNumber; }

            set { _licenseNumber = value; }

        }

        private DateTime _licenseStartDate;

        public DateTime LicenseStartDate

        {

            get { return _licenseStartDate; }

            set { _licenseStartDate = value; }

        }

        private DateTime _licenseExpiryDate;

        public DateTime LicenseExpiryDate

        {

            get { return _licenseExpiryDate; }

            set { _licenseExpiryDate = value; }

        }

        public Member()

        {

        }

        public Member(long _id, string _firstName, string _lastName, string _email, string _contactNumber, string _licenseNumber, DateTime _licenseStartDate, DateTime _licenseExpiryDate)

        {

            Id = _id;

            FirstName = _firstName;

            LastName = _lastName;

            Email = _email;

            ContactNumber = _contactNumber;

            LicenseNumber = _licenseNumber;

            LicenseStartDate = _licenseStartDate;

            LicenseExpiryDate = _licenseExpiryDate;

        }

    }

}



class -----MemberCar



using System;


using System.Collections.Generic;

using System.Linq;

namespace CarPoolingReq6

{

    class MemberCar

    {

        private long _id;

        public long Id

        {

            get { return _id; }

            set { _id = value; }

        }

        private long _memberId;

        public long MemberId

        {

            get

            {

                return _memberId;

            }

            set

            {

                _memberId = value;

            }

        }

        private long _carId;

        public long CarId

        {

            get

            {

                return _carId;

            }

            set

            {

                _carId = value;

            }

        }

        private string _carRegistrationNumber;

        public string CarRegistrationNumber

        {

            get

            { return _carRegistrationNumber; }

            set { _carRegistrationNumber = value; }

        }

        private string _carColor;

        public string CarColor

        {

            get

            {

                return _carColor;

            }

            set

            {

                _carColor = value;

            }

        }

        public MemberCar() { }

        public MemberCar(long id, long memberId, long carId, string carRegistrationNumber, string carColor)

        {

            Id = id;

            MemberId = memberId;

            CarId = carId;

            CarRegistrationNumber = carRegistrationNumber;

            CarColor = carColor;

        }

        public class CarPoolingSystem

        {

            private List<Member> members;

            private List<Car> cars;

            private List<MemberCar> memberCars;

            public CarPoolingSystem(List<Member> members, List<Car> cars, List<MemberCar> memberCars)

            {

                this.members = members;

                this.cars = cars;

                this.memberCars = memberCars;

            }

            public Dictionary<string, List<MemberCar>> GroupByColor()

            {

                var result = new Dictionary<string, List<MemberCar>>();

                foreach (var car in cars)

                {

                    var color = car.Company.ToLower();

                    if (!result.ContainsKey(color))

                    {

                        result[color] = new List<MemberCar>();

                    }

                    var memberCarsWithColor = memberCars.Where(mc => mc.CarId == car.Id);

                    result[color].AddRange(memberCarsWithColor);

                }

                return result;

            }

        }

    }

   
