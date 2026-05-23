//Journal with Mood Tracker
//2026/05/02
//By: Jacob Swift
//Many thanks to my friends and colleagues who helped me understand the concepts and overcome challenges writing this.
//

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Console.WriteLine("How are you feeling today?");
                Console.WriteLine("1. Happy");
                Console.WriteLine("2. Sad");
                Console.WriteLine("3. Stressed");
                Console.WriteLine("4. Excited");
                Console.WriteLine("5. Tired");
                Console.WriteLine("6. Custom mood");

                Console.Write("Choose a mood: ");
                string moodChoice = Console.ReadLine();

               string mood = "";

                if (moodChoice == "1") mood = "Happy";
                else if (moodChoice == "2") mood = "Sad";
                else if (moodChoice == "3") mood = "Stressed";
                else if (moodChoice == "4") mood = "Excited";
                else if (moodChoice == "5") mood = "Tired";
                else if (moodChoice == "6")
                {
                    Console.Write("Enter your mood: ");
                    mood = Console.ReadLine();
                }
                else
                {
                    mood = "Neutral";
                }


                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._responseText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
        }
    }
}