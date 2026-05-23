public class Entry
{
    public string _date;
    public string _promptText;
    public string _responseText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_responseText}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_mood}|{_promptText}|{_responseText}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');

        Entry entry = new Entry();
        entry._date = parts[0];
        entry._mood = parts[1];
        entry._promptText = parts[2];
        entry._responseText = parts[3];

        return entry;
    }
}

