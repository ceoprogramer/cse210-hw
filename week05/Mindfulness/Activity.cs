public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n {_description}.");
        Console.Write(  "How long, in seconds, would you like to do this activity? ");
        _duration=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Get Ready!");
        ShowSpinner();

    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity!");
    }
    public void PerformActivity()
    {
        DisplayStartMessage();
        // Simulate the activity duration
        System.Threading.Thread.Sleep(_duration * 1000);
        DisplayEndMessage();
    }

    public void ShowSpinner()
    {
        string[] spinner = { "|", "/", "-", "\\","|", "/", "-", "\\" };
        for (int i = 0; i < 9; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            System.Threading.Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
