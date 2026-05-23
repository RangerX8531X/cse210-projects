class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "When have you felt peace this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list positive things in your life.")
    {
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You will begin shortly...");
        ShowCountdown(5);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        int count = 0;

        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}