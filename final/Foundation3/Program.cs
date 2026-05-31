using System;

class Program
{
    static void Main()
    {
        Address addr = new Address("1 Event St", "Rexburg", "ID", "USA");

        Lecture l = new Lecture("Tech Talk", "C# Deep Dive", "June 1", "6 PM", addr, "Dr. Smith", 100);
        Reception r = new Reception("Wedding", "Smith Wedding", "June 5", "4 PM", addr, "rsvp@email.com");
        OutdoorGathering o = new OutdoorGathering("Concert", "Summer Music", "June 10", "7 PM", addr, "Sunny");

        Event[] events = { l, r, o };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
        }
    }
}