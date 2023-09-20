using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        // Write the Loop
        while (guess != magicNumber)
        {
            // Ask for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Response
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}