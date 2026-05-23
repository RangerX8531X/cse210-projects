class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What could you learn from this experience?",
        "What made this moment different from others?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity helps you reflect on times of strength and resilience.")
    {
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("\nThink about it...");
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }
    }
}
