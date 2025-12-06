using System;

// Developer: Carl Hylton
// Course: CSE 210 – Programming with Classes
// Week 12 – Final Project Milestone (Foundation 4)
//
// Progress Update:
// For this milestone, I completed the first two Foundation programs.
// Program 1 (Abstraction) includes the Video and Comment classes,
// with methods to display video information and all associated
// comments. Program 2 (Encapsulation) includes the Product,
// Customer, Address, and Order classes, with methods for calculating
// totals, generating packing and shipping labels, and determining
// domestic vs. international shipping.

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 East Blue St", "Shells Town", "East Blue", "USA");
            Customer customer1 = new Customer("Monkey D. Luffy", address1);

            Address address2 = new Address("456 Grand Line Rd", "Marineford", "New World", "Japan");
            Customer customer2 = new Customer("Roronoa Zoro", address2);

            Product product1 = new Product("Straw Hat", "HAT001", 20.0);
            Product product2 = new Product("Katana", "SWORD001", 150.0);
            Product product3 = new Product("Meat", "FOOD001", 10.0);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1, 2);
            order1.AddProduct(product3, 5);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2, 1);
            order2.AddProduct(product3, 3);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total: $" + order1.CalculateTotal());
            Console.WriteLine();

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total: $" + order2.CalculateTotal());
        }
    }
}
