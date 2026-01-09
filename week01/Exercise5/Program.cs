using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
}

static void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to the Program!");
}

static void PromptUserName()
{
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
}

static int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

static int SquareNumber(int number)
{
    int square = number * number;
    return square;
}