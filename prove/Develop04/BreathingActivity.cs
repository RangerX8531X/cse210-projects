class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding your breathing slowly.")
    {
    }

    protected override void RunActivity()
    {
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            PulseBreath("Breathe in...", 5, true);
            PulseBreath("Breathe out...", 5, false);
        }
    }

    private void PulseBreath(string message, int seconds, bool expand)
    {
        int steps = seconds;

        for (int i = 0; i < steps; i++)
        {
            Console.Clear();

            int size;

            if (expand)
            {
                size = i + 1;
            }
            else
            {
                size = steps - i;
            }

            Console.WriteLine(message);
            Console.WriteLine();

            string spaces = new string(' ', 10 - size);

            Console.Write(spaces);

            for (int j = 0; j < size; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("\n");
            Console.WriteLine($"Time remaining: {steps - i}");

            Thread.Sleep(1000);
        }
    }
}