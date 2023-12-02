using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Foundation Program 2 - Encapsulation with Online Ordering\n");
        Console.Write("---------------------------------------------------------\n");
        Console.WriteLine("(Encapsulation: The act of enclosing something, as if it were in a capsule.)\n");

        Address address1 = new Address("879 Everett Pl Apt. 1", "Rexburg", "ID", "USA");
        Address address2 = new Address("5103 Eureka Way", "Vancouver", "WA", "USA");
        Address address3 = new Address("1110 NE 100th ave", "Vancouver", "WA", "USA");

        Customer customer1 = new Customer("Bryant Smith", address1);
        Customer customer2 = new Customer("Jean Smith", address2);
        Customer customer3 = new Customer("Janae Smith", address3);

        Product product1 = new Product("Large TV", "TV-2468", 175.0m, 1);
        Product product2 = new Product("Christmas Tree", "TRE-123", 75.0m, 1);
        Product product3 = new Product("Griddle", "GRI-345", 65.0m, 2);
        Product product4 = new Product("Shoes", "SHO-4321", 125.0m, 4);

        Order order1 = new Order(customer1, new List<Product> {product1, product3});
        Order order2 = new Order(customer2, new List<Product> {product1, product3, product4});
        Order order3 = new Order(customer3, new List<Product> {product2, product3});

        Console.WriteLine("===============================================");
        Console.WriteLine("                  Order #1");
        Console.WriteLine("===============================================");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetLabel());
        Console.WriteLine("");
        Console.WriteLine("Shipping: $" + order1.ShippingTotal().ToString("F2"));        
        Console.WriteLine("Total Cost: $" + order1.CalculateTotal().ToString("F2"));
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Packing List:");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine("===============================================\n");
        Console.WriteLine("");

        Console.WriteLine("===============================================");
        Console.WriteLine("                  Order #2");
        Console.WriteLine("===============================================");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetLabel());
        Console.WriteLine("");
        Console.WriteLine("Shipping: $" + order2.ShippingTotal().ToString("F2"));  
        Console.WriteLine("Total Cost: $" + order2.CalculateTotal().ToString("F2"));
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Packing List:");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine("===============================================\n");
        Console.WriteLine("");

        Console.WriteLine("===============================================");        
        Console.WriteLine("                  Order #3");
        Console.WriteLine("===============================================");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetLabel());
        Console.WriteLine("");
        Console.WriteLine("Shipping: $" + order3.ShippingTotal().ToString("F2"));  
        Console.WriteLine("Total Cost: $" + order3.CalculateTotal().ToString("F2"));
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Packing List:");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(order3.GetPackLabel());
        Console.WriteLine("===============================================\n");
        Console.WriteLine("");
    }
}