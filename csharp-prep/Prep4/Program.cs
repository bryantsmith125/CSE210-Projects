using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   // Create the list
        List<int> numbers = new List<int>();
        // Make the Loop
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number, type 0 when finished): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Make an equation for the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Get the average
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Get the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

    }
}