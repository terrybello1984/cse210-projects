using System;

namespace OnlineOrdering
{
    // Class to represent a product
    public class Product
    {
        // Private member variables for product details
        private string name;
        private string productId;
        private decimal price;
        private int quantity;

        // Constructor to initialize the product properties
        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        // Method to calculate the total cost of the product
        public decimal GetTotalCost()
        {
            return price * quantity;
        }

        // Getter for the product name
        public string GetName()
        {
            return name;
        }

        // Getter for the product ID
        public string GetProductId()
        {
            return productId;
        }
    }
}
