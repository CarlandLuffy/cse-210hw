using System;

public class Reflection : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public Reflection() : base("Reflection")
    {
        _prompts = new string[]
        {
            "Think of a time when you felt the most joy in your life.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new string[]
        {
            "Why was this meaningful to you?",
            "Have you done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What did you learn about yourself?"
        };
    }

    public override void Run()
    {
        SetStartMessage("This activity helps you reflect on times you showed strength and resilience.");
        SetEndMessage("Good job reflecting.");
        DisplayInstructions();

        Console.WriteLine("Choose a prompt number (1-" + _prompts.Length + ") or press Enter for 1:");
        string pickText = Console.ReadLine();
        int pick = 1;
        int.TryParse(pickText, out pick);
        if (pick < 1 || pick > _prompts.Length) pick = 1;

        Console.WriteLine();
        Console.WriteLine("> " + _prompts[pick - 1]);
        Console.WriteLine("Press Enter when you are ready to start thinking.");
        Console.ReadLine();

        Console.Write("How many questions do you want to consider? ");
        string countText = Console.ReadLine();
        int count = 0;
        int.TryParse(countText, out count);
        if (count < 1) count = 1;

        Console.WriteLine();
        int i = 0;
        int asked = 0;
        while (asked < count)
        {
            Console.WriteLine("- " + _questions[i]);
            Console.WriteLine("Think for a moment, then press Enter to continue.");
            Console.ReadLine();

            i = i + 1;
            if (i >= _questions.Length) i = 0;
            asked = asked + 1;
        }

        ShowEnd();
        PauseWithAnimation();
    }
}

