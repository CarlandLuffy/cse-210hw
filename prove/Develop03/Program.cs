using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        var options = new List<(ScriptureReference, string)>
        {
            (new ScriptureReference("John", 3, 16),
             "For God so loved the world, that he gave his only begotten Son, " +
             "that whosoever believeth in him should not perish, but have everlasting life."),

            (new ScriptureReference("Proverbs", 3, 5, 6),
             "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
             "In all thy ways acknowledge him, and he shall direct thy paths."),

            (new ScriptureReference("Mosiah", 2, 17),
             "When ye are in the service of your fellow beings ye are only in the service of your God.")
        };

        var rand = new Random();
        var pick = options[rand.Next(options.Count)];
        var scripture = new Scripture(pick.Item1, pick.Item2);

      
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine();
            Console.Write("Press ENTER to hide a few words, or type 'quit' to end: ");

            string input = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (input == "quit")
                break;

            
            int toHide = rand.Next(2, 5);
            scripture.HideRandomWords(toHide);

            if (scripture.AllWordsHidden)
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Nice job!");
                break;
            }
        }
    }
}

