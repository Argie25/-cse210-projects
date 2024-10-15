using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a customer in the USA
        Customer customer1 = new Customer("John Doe", "123 Maple Street", "Los Angeles", "CA", "USA");

        // Create an order for customer1
        Order order1 = new Order(customer1);

        // Add products to order1
        order1.AddProduct("Laptop", "LP1001", 999.99, 1);
        order1.AddProduct("Mouse", "MS2002", 29.99, 2);

        // Print packing label, shipping label, and total price for order1
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("\n-------------------------\n");

        // Create a customer outside the USA
        Customer customer2 = new Customer("Jane Smith", "456 King Street", "Toronto", "Ontario", "Canada");

        // Create an order for customer2
        Order order2 = new Order(customer2);

        // Add products to order2
        order2.AddProduct("Smartphone", "SP3003", 699.99, 1);
        order2.AddProduct("Headphones", "HP4004", 59.99, 3);

        // Print packing label, shipping label, and total price for order2
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}