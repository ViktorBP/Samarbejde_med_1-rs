using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public Address Address { get; set; }
        public CreditCardDetails CreditCardDetails { get; set; }
        public Basket Basket { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class CreditCardDetails
    {
        public string CardNumber { get; set; }
        public string ExpDate { get; set; }
        public string CVC { get; set; }
    }

    public class Address
    {
        public string StreetNane { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
