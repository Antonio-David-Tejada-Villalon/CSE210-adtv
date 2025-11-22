using System;
using System.Collections.Generic;

namespace OnlineOrderingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Online Ordering Program ===\n");

            // Create Address 1 (USA)
            Address address1 = new Address(
                "123 Main St",
                "Springfield",
                "IL",
                "USA"
            );

            // Create Customer 1 (USA)
            Customer customer1 = new Customer("Alice Smith", address1);

            // Create Order 1
            Order order1 = new Order(customer1);

            // Add Products to Order 1
            order1.AddProduct(new Product("Wireless Mouse", "WM001", 25.99, 2));
            order1.AddProduct(new Product("USB Cable", "UC002", 7.50, 3));

            // Display Order 1 Info
            Console.WriteLine("--- Order 1 ---");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

            // Create Address 2 (International)
            Address address2 = new Address(
                "Rue de la Paix",
                "Paris",
                "Île-de-France",
                "France"
            );

            // Create Customer 2 (International)
            Customer customer2 = new Customer("Jean Dupont", address2);

            // Create Order 2
            Order order2 = new Order(customer2);

            // Add Products to Order 2
            order2.AddProduct(new Product("Laptop Charger", "LC003", 49.99, 1));
            order2.AddProduct(new Product("Notebook", "NB004", 8.99, 5));

            // Display Order 2 Info
            Console.WriteLine("--- Order 2 ---");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");

            Console.WriteLine("Program complete.");
        }
    }
}