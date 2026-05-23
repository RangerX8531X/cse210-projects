class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Quit");

            Console.Write("Select: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Select goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;

                case "4":
                    manager.DisplayScore();
                    break;

                case "5":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;

            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;

            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }
}