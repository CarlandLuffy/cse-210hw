using System;

public class Breathing : Activity
{
    public Breathing() : base("Breathing")
    {
    }

    public override void Run()
    {
        SetStartMessage("This activity helps you relax by breathing in and out slowly.");
        SetEndMessage("Good job finishing the breathing activity.");
        DisplayInstructions();

        Console.Write("How many cycles do you want to do? ");
        string input = Console.ReadLine();
        int cycles = 0;
        int.TryParse(input, out cycles);

        int done = 0;
        while (done < cycles)
        {
            Console.WriteLine("Breathe in...");
            Console.ReadLine(); 
            Console.WriteLine("Breathe out...");
            Console.ReadLine();
            done = done + 1;
        }

        ShowEnd();
        PauseWithAnimation();
    }
}

