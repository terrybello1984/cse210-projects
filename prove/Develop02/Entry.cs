using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt}\",\"{Response}\"";
    }

    public static Entry FromCsv(string csvLine)
    {
        var parts = csvLine.Split(new[] { "\",\"" }, StringSplitOptions.None);
        var date = DateTime.Parse(parts[0].Trim('"'));
        var prompt = parts[1].Trim('"');
        var response = parts[2].Trim('"');
        return new Entry(prompt, response) { Date = date };
    }
}
