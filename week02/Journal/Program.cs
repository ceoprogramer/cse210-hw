//Alumn: Fabiola Sánchez
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();

        PromptGenerator promptGenerator = new PromptGenerator();
        anEntry.Display();
        Console.WriteLine("Welcome to the Journal Program!");

        int response = 1;

        while (response != 5)
        {
            Console.Write("What do you want to do? ");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Quit");
            response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    Console.WriteLine("You chose to Write.");
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entry = Console.ReadLine();
                    anEntry = new Entry();
                    anEntry._promptText = prompt;
                    anEntry._entryText = entry;
                    anEntry._date = DateTime.Now.ToShortDateString();
                    theJournal.AddEntry(anEntry);

                    break;
                case 2:
                    Console.WriteLine("You chose to Display.");
                    theJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Please enter a filename to load:");
                    string filenametoload = Console.ReadLine();
                    theJournal.LoadFromFile(filenametoload);

                    break;
                case 4:
                    Console.WriteLine("Please enter a filename to save:");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option from the menu.");
                    break;
            }

            
        }

    }
}