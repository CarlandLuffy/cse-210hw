using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> nums = new List<int>();
        while (true)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;
            nums.Add(n);
        }

        if (nums.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        int sum = 0, max = int.MinValue, minPos = int.MaxValue;
        foreach (int v in nums)
        {
            sum += v;
            if (v > max) max = v;
            if (v > 0 && v < minPos) minPos = v;
        }

        double avg = sum / (double)nums.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        if (minPos == int.MaxValue) Console.WriteLine("The smallest positive number is: (none)");
        else Console.WriteLine($"The smallest positive number is: {minPos}");

        nums.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int v in nums) Console.WriteLine(v);
    }
}
