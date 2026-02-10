//--- Mindfulness Project ---
//--- Main Program Class ---
//--- Alumn: Fabiola Sánchez 
using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

    //Menu to select activities
    static void ShowMenu()

    {
        string choice = "";
        while (choice != "4")
        {

            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity(30);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectionActivity = new ReflectingActivity(30);
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity(30);
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowMenu();
                    break;
            }        
        }
    }



}