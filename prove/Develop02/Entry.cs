using System;

public class Entry
{
    // Attributes (fields)
    public string _givenPrompt;
    public string _entryText;
    public string _entryDateTime;

    // Constructor (optional but helpful)
    public Entry()
    {
        _givenPrompt = "";
        _entryText = "";
        _entryDateTime = DateTime.Now.ToString("MMMM dd, yyyy");
    }

    // Behavior: Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTime}");
        Console.WriteLine($"Prompt: {_givenPrompt}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
