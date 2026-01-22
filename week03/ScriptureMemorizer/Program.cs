using System;

// --- Main Program Class ---
class Program
{
    static void Main(string[] args)
    {
        //  Initialize a library of scriptures
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me")
        };

        //  Select a random scripture from the library
        Random random = new Random();
        Scripture selectedScripture = library[random.Next(library.Count)];

// Main loop to display and hide words
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (selectedScripture.IsCompletelyHidden())
                break;

            selectedScripture.HideRandomWords(3);
        }
    }
}