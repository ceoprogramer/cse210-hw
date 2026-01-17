public class PromptGenerator
{
    private List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "Describe a challenge you faced recently.",
            "What did you do to help someone today?",
            "Write about someone who inspires you today."
        };

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}