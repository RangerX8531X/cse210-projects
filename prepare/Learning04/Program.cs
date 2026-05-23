using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Neil Armstrong", "Astrophysics");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("George Orwell", "Sociology", "19", "84-Today");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Terry Pratchett", "Creative Writing", "World Bilding");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}