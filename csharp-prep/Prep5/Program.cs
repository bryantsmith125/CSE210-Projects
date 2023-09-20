using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();

        int squarednumber = SquareNumber(usernumber);

        DisplayResult(username, squarednumber);
    }
    // Function for displaying the welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // Function to ask for username
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    // Function to ask for a favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    // Function to square the favorite number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    // Function to show the result of the number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}