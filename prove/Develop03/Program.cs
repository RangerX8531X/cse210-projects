using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether", 12, 27);

        string text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.quit";

        Scripture scripture = new Scripture(reference, text);

        Score score = new();

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Current Score: {score.GetScore()}");
            Console.WriteLine();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words hidden!");
                Console.WriteLine($"Final Score: {score.GetScore()}");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine($"\nFinal Score: {score.GetScore()}");
                break;
            }

            score.AddPoints(5);

            scripture.HideRandomWords();
        }
    }
}