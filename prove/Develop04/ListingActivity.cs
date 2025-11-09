using System;

public class Listing : Activity
{
    private string[] _prompts;

    public Listing() : base("Listing")
    {
        _prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        SetStartMessage("This activity helps you list as many good things as you can in a topic.");
        SetEndMessage("Nice work. Thanks for listing.");
        DisplayInstructions();

        Console.Write("How many seconds? ");
        string s = Console.ReadLine();
        int secs = 0;
        int.TryParse(s, out secs);
        SetTimer(secs);

        Console.WriteLine("Get ready...");
        PauseWithAnimation();

        Random r = new Random();
        string prompt = _prompts[r.Next(0, _prompts.Length)];
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("You will start listing in 3 seconds...");
        int n = 3;
        while (n > 0)
        {
            Console.Write(n + " ");
            System.Threading.Thread.Sleep(1000);
            n = n - 1;
        }
        Console.WriteLine();

        Console.WriteLine("Start typing items (press Enter after each).");
        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(GetTimer());

        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string line = Console.ReadLine();
                if (line != "" && line != null)
                {
                    count = count + 1;
                }
            }
        }

        Console.WriteLine("You listed " + count + " items.");
        ShowEnd();
        PauseWithAnimation();
    }
}

