public class ReflectingActivity : Activity
{
   private List<string> _prompts; 
   private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a significant challenge.",
            "Recall a moment when you made a positive impact on someone else's life.",
            "Reflect on an experience where you learned something valuable about yourself."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn about yourself from this experience?",
            "How can you apply the lessons from this experience to your current life?"
        };
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public void AskReflectionQuestions()
    {
        Random rand = new Random();
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner();
        }
    }

    public void Run()
    {


        DisplayStartMessage();
        GetRandomPrompt();  
        Console.WriteLine("Take a moment to reflect on the prompt above...");
        ShowSpinner();
          DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);       

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            AskReflectionQuestions();
            currentTime = DateTime.Now;
            
           
        }    
         DisplayEndMessage();
    }

}