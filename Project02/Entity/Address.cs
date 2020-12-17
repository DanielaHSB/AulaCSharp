using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Entity
{
    public class Address
    {
        private string streetName;
        private string streetNumber;
        private string postalCode;
        private string city;
        private string province;
        private int idEmployee;
        private int idAddress;

        public string StreetName { get => streetName; set => streetName = value; }
        public string StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdAddress { get => idAddress; set => idAddress = value; }

        public Address(string streetName, string streetNumber, string postalCode, string city, string province)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.postalCode = postalCode;
            this.city = city;
            this.province = province;
        }

        public Address()
        {

        }
    }
}
