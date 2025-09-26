using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int percent = int.Parse(Console.ReadLine());

        string letter;

        if (percent >= 90) letter = "A";
        else if (percent >= 80) letter = "B";
        else if (percent >= 70) letter = "C";
        else if (percent >= 60) letter = "D";
        else letter = "F";

        string sign = "";
        int lastDigit = percent % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7) sign = "+";
            else if (lastDigit < 3) sign = "-";
        }
        else if (letter == "A" && percent < 93) sign = "-";

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (percent >= 70) Console.WriteLine("Congrats, you passed!");
        else Console.WriteLine("Keep working, you’ll get it next time.");
    }
}
