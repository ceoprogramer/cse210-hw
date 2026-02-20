//Alumn: Fabiola Sánchez
// This is the main entry point for the EternalQuest project.
// Using polymorphism, inheritance and encapsulation
//This program keeps track of various kinds of goals that people have, which are goals in their real life
//This program could be set up to keep track of your progress on these goals and offer points, awards, or other celebrations to keep you encouraged to keep working.
// This program must do the following:
// 1. Provide for simple goals that can be marked complete and the user gains some value.
// 2. Provide for eternal goals that are never complete, but each time the user records them, they gain some value
//3. Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
//4. Display the user's score.
//5. Allow the user to create new goals of any type.
//6. Allow the user to record an event (meaning they have accomplished a goal and should receive points).
//7. Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
//8. Allow the user's goals and their current score to be saved and loaded.


using System;

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
        Console.WriteLine("You have 333 points.");
        GoalManager goalManager = new GoalManager();

        
        while (choice != "6")
        {
            Console.WriteLine($"You have {goalManager.GetScore()} points.");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":

                    goalManager.DisplayPlayerInfo();
                    break;
                    
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
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