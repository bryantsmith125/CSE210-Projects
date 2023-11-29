using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Foundation Program 2 - Encapsulation with Online Ordering\n");
        Console.Write("---------------------------------------------------------\n");
        Console.WriteLine("(Encapsulation: The act of enclosing something, as if it were in a capsule.)\n");

        Address address1 = new Address("879 Everett Pl Apt. 1, "Rexburg", "ID", "USA");

        Customer customer1 = new Customer("Bryant Smith", address1);

        Console.WriteLine("===============================================");
        Console.WriteLine("                  Order #1");
        Console.WriteLine("===============================================");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetLabel());
        Console.WriteLine("");


    }
}