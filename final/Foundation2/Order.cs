using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    // Class to represent an order
    public class Order
    {
        // Private member variables for the list of products and the customer
        private List<Product> products;
        private Customer customer;

        // Constructor to initialize the order with a customer and a list of products
        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Method to calculate the total cost of the order
        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.GetTotalCost();
            }

            // Add shipping cost based on the customer's location
            if (customer.IsInUSA())
            {
                totalCost += 5; // USA shipping cost
            }
            else
            {
                totalCost += 35; // International shipping cost
            }

            return totalCost;
        }

        // Method to get the packing label for the order
        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();
            foreach (Product product in products)
            {
                packingLabel.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
            }
            return packingLabel.ToString();
        }

        // Method to get the shipping label for the order
        public string GetShippingLabel()
        {
            return $"{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
        }
    }
}
