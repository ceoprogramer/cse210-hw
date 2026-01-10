// Exercise 3: Write a program that generates a random "magic number" between 1 and 100. The user should guess the number, and the program should provide feedback on whether the guess is too high, too low, or correct. The program should continue to prompt the user until they guess the correct number.
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number (between 1 and 100): ");
            
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the magic number!");
            }
        }
    }
}