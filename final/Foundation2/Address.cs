using System;

namespace OnlineOrdering
{
    // Class to represent an address
    public class Address
    {
        // Private member variables for address details
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        // Constructor to initialize the address properties
        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        // Method to determine if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToLower() == "usa";
        }

        // Method to return the address as a formatted string
        public string GetAddressString()
        {
            return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
        }
    }
}
