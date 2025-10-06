using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.Initialize();

        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("-------------------------");

        Console.Write("Enter a prompt for your journal entry: ");
        string prompt = Console.ReadLine();

        Console.Write("Now type your entry: ");
        string text = Console.ReadLine();

        Entry myEntry = new Entry();
        myEntry._givenPrompt = prompt;
        myEntry._entryText = text;
        myEntry._entryDateTime = DateTime.Now.ToString("MMMM dd, yyyy");

        myJournal.AppendEntry(myEntry);

        Console.WriteLine("Heres what you wrote:");
        Console.WriteLine("========================");
        myJournal.Display();
    }
}
