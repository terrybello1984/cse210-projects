using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");

            // Create some customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create some products
            Product product1 = new Product("Laptop", "A123", 999.99m, 1);
            Product product2 = new Product("Mouse", "B456", 25.99m, 2);
            Product product3 = new Product("Keyboard", "C789", 49.99m, 1);
            Product product4 = new Product("Monitor", "D012", 199.99m, 2);

            // Create orders and add products to them
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Store the orders in a list
            List<Order> orders = new List<Order> { order1, order2 };

            // Display details for each order
            foreach (Order order in orders)
            {
                Console.WriteLine("Packing Label:");
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine("Shipping Label:");
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
                Console.WriteLine();
            }
        }
    }
}
