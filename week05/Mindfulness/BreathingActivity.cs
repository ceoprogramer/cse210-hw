public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);       

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {

            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Hold...");
            ShowCountdown(7);
            Console.WriteLine("Breathe out...");
            ShowCountdown(8);
            currentTime = DateTime.Now;
        }


       

        DisplayEndMessage();
    }
}