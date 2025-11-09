using System;
using System.Threading;

public abstract class Activity
{
    private int _timer;              
    private string _startMessage;
    private string _endMessage;
    private string _name;

    public Activity(string name)
    {
        _name = name;
        _startMessage = "";
        _endMessage = "";
        _timer = 0;
    }

    public void SetTimer(int seconds)
    {
        _timer = seconds;
    }

    public int GetTimer()
    {
        return _timer;
    }

    public void SetStartMessage(string text)
    {
        _startMessage = text;
    }

    public void SetEndMessage(string text)
    {
        _endMessage = text;
    }

    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to the " + _name + " activity!");
        Console.WriteLine(_startMessage);
        Console.WriteLine();
    }

    public void PauseWithAnimation()
    {
       
        int i = 0;
        while (i < 3)
        {
            Console.Write(".");
            Thread.Sleep(500);
            i = i + 1;
        }
        Console.WriteLine();
    }

    public void ShowEnd()
    {
        Console.WriteLine(_endMessage);
    }

    public abstract void Run();
}







   