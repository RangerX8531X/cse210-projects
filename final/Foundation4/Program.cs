using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("2026-05-01", 30, 3.0));
        activities.Add(new Cycling("2026-05-02", 45, 12.0));
        activities.Add(new Swimming("2026-05-03", 60, 40));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}