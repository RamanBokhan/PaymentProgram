using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProgram
{
    internal class Address
    {
        public string City {  get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }

        public Address(string city, string street, string houseNumber, string flatNumber)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
                
        }

        public override string ToString()
        {
            return "Address:" + City + ", " + Street + ", " + HouseNumber + ", " + FlatNumber;
        }
    }
}
