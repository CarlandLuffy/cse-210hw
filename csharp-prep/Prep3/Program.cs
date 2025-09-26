using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        string again = "yes";

        while (again == "yes")
        {
            int magic = rng.Next(1, 101);
            int guesses = 0, guess = -1;

            Console.WriteLine("I'm thinking of a number 1–100.");
            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess < magic) Console.WriteLine("Higher");
                else if (guess > magic) Console.WriteLine("Lower");
                else Console.WriteLine($"You guessed it! Guesses: {guesses}");
            }

            Console.Write("Play again? (yes/no): ");
            again = Console.ReadLine().Trim().ToLower();
        }
    }
}
