using System;
using System.Collections.Generic;
using System.IO;

// Hey brother gibbions I added a random prompt generator so each time I open the journal it feels new this was alot lol.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.Initialize();

        bool running = true;

        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("-------------------------");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

       if (choice == "1")
{
   
    string[] prompts = {
        "Who was the most interesting person I met today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could redo one thing today, what would it be?"
    };

    Random rnd = new Random();
    string prompt = prompts[rnd.Next(prompts.Length)];

    Console.WriteLine();
    Console.WriteLine($"Prompt: {prompt}");
    Console.Write("Now type your entry: ");
    string text = Console.ReadLine();


             
            

                Entry myEntry = new Entry();
                myEntry._givenPrompt = prompt;
                myEntry._entryText = text;
                myEntry._entryDateTime = DateTime.Now.ToString("MMMM dd, yyyy");

                myJournal.AppendEntry(myEntry);

                Console.WriteLine();
                Console.WriteLine("Entry saved I had fun doing this!");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Here's what you wrote:");
                Console.WriteLine("========================");
                myJournal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a filename to save your journal (example: journal.txt): ");
                string fileName = Console.ReadLine();

                if (fileName != "")
                {
                    myJournal.SaveToFile(fileName);
                }
                else
                {
                    Console.WriteLine("Invalid filename.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string fileName = Console.ReadLine();

                if (fileName != "")
                {
                    myJournal.LoadFromFile(fileName);
                }
                else
                {
                    Console.WriteLine("Invalid filename.");
                }
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That's not a valid choice, please try again.");
            }
        }
    }
}
