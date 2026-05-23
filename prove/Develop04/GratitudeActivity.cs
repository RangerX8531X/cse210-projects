class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "Who are you thankful for?",
        "What opportunity are you grateful for?",
        "What challenge helped you grow recently?",
        "What is something simple that brings you joy?"
    };

    public GratitudeActivity()
        : base("Gratitude Activity",
               "This activity helps you focus on gratitude and positivity.")
    {
    }

    protected override void RunActivity()
    {
        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nReflect on the following prompt:");
        Console.WriteLine($"> {prompt}");

        Console.WriteLine("\nTake a moment to think...");
        ShowSpinner(5);

        Console.WriteLine("\nNow write a few things you are grateful for:");

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} grateful thoughts!");
    }
}