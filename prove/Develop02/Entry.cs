using System;

public class Entry
{
    
    public string _givenPrompt;
    public string _entryText;
    public string _entryDateTime;

    
    public Entry()
    {
        _givenPrompt = "";
        _entryText = "";
        _entryDateTime = DateTime.Now.ToString("MMMM dd, yyyy");
    }

    
    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTime}");
        Console.WriteLine($"Prompt: {_givenPrompt}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
