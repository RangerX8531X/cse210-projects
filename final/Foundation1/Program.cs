using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Basics", "John", 300);
        v1.AddComment(new Comment("Alice", "Great video!"));
        v1.AddComment(new Comment("Bob", "Very helpful"));
        v1.AddComment(new Comment("Sara", "Thanks!"));

        Video v2 = new Video("OOP Explained", "Mike", 450);
        v2.AddComment(new Comment("Tom", "Now I get it"));
        v2.AddComment(new Comment("Jane", "Nice examples"));
        v2.AddComment(new Comment("Luke", "Awesome"));

        videos.Add(v1);
        videos.Add(v2);

        foreach (Video v in videos)
        {
            v.Display();
            Console.WriteLine();
        }
    }
}