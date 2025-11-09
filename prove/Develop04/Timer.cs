using System;
using System.Threading;

public class Timer
{
    public void Countdown(int seconds)
    {
        int n = seconds;
        while (n > 0)
        {
            Console.Write(n + " ");
            Thread.Sleep(1000);
            n = n - 1;
        }
        Console.WriteLine();
    }

  
    public void Spinner(int seconds)
    {
        char[] frames = new char[] { '|', '/', '-', '\\' };
        int i = 0;
        int totalTicks = seconds * 4; 
        while (i < totalTicks)
        {
            Console.Write(frames[i % 4]);
            Thread.Sleep(250);
            Console.Write('\b'); 
            i = i + 1;
        }
        Console.WriteLine();
    }
}
