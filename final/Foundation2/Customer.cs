using System;

namespace OnlineOrdering
{
    // Class to represent a customer
    public class Customer
    {
        // Private member variables for customer's name and address
        private string name;
        private Address address;

        // Constructor to initialize the customer's name and address
        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        // Method to determine if the customer lives in the USA
        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        // Getter for the customer's name
        public string GetName()
        {
            return name;
        }

        // Getter for the customer's address
        public Address GetAddress()
        {
            return address;
        }
    }
}
