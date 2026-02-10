public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int duration) : base("Listing Activity", "List as many responses you can to the following prompt.", duration)
    {
        _prompts = new List<string>
        {
            "List three things you are grateful for.",
            "List three people who have positively impacted your life.",
            "List three accomplishments you are proud of.",
            "List three places you want to visit."
        };
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser ()
    {
        return _prompts;
    }

    public void Run()
    {
        DisplayStartMessage();
        GetRandomPrompt();
        
        Console.WriteLine($"You make begin in: ");
       ShowCountdown(5);
               
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        string  response="";

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            
            Thread.Sleep(1000); 
            currentTime = DateTime.Now;
            response=Console.ReadLine();
        }
    
        Console.WriteLine("Time's up! Great job listing your items.");
        DisplayEndMessage();
    }
}