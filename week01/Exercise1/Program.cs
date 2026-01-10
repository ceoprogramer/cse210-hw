using System;

// Exercise 1: Write a program that asks the user for their first and last name, then displays their full name in the format "Last Name, First Name Last Name".
class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their name
        Console.Write("What is your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}