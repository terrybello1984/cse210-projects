using System;

namespace EventPlanning
{
    // Class to represent an address
    public class Address
    {
        // Private member variables for address details
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        // Constructor to initialize the address properties
        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        // Method to return the address as a formatted string
        public string GetAddressString()
        {
            return $"{_streetAddress}, { _city}, {_stateProvince}, {_country}";
        }
    }
}
