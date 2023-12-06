using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Foundation Program 3\n");
        Console.Write("--------------------\n");
        Console.WriteLine("(Inheritance: The ability for one class to obtain the attributes and methods of another class directly, without having to type them.)\n");

        Address address1 = new Address("879 Everett Pl Apt. 1", "Rexburg", "ID", "USA");
        Address address2 = new Address("5103 Eureka Way", "Vancouver", "WA", "USA");
        Address address3 = new Address("1110 NE 100th ave", "Vancouver", "WA", "USA");

        Reception reception = new Reception("Fiscal Year Celebration Reception", "Another successful year", "12/05/2023", "4", address1, "2468@email.com");
        Lecture lecture = new Lecture("Lectures on Faith", "Understand the foundations of the first principle of the gospel!", "12/05/2023", "3", address2, "President Joseph Smith", 150);
        OutdoorGathering outdoorGathering = new OutdoorGathering("Lets Head Outside!", "Smores and Hotdogs", "12/05/2023", "2", address3, "Overcast with a slight chance of rain.");


        Console.WriteLine("\nReception:");
        Console.WriteLine("-----------------");       
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("Full Details:");       
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("***********************************");

        Console.WriteLine("\nLecture:");
        Console.WriteLine("-------------"); 
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("***********************************");

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine("-----------------"); 
        Console.WriteLine("Standard Details:"); 
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("Full Details:");        
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("***********************************");
    }
}