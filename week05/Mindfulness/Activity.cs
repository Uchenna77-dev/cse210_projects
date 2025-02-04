using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Start()
    {
        DisplayIntroduction();
        DisplaySpinner(5);
        PerformActivity();
        DisplayConclusion();
    }

    protected virtual void DisplayIntroduction()
    {
        Console.WriteLine($"\nWelcome to {_name} Activity!!!.\n{_description}.\n");
        Console.Write("How long in seconds would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int userDuration))
        {
            _duration = userDuration;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration.");
        }
        
    }

    protected abstract void PerformActivity();

    protected virtual void DisplayConclusion()
    {
        Console.WriteLine("Well Done!!!");
        DisplaySpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of  {_name} Activity.");
        DisplaySpinner(2);
    }

    protected void DisplaySpinner(int duration)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }

    public virtual void ShowCountDown(int duration){
        for(int i=5; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner()
    {
        Console.Write("Processing");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public virtual void Run()
    {
        Console.WriteLine($"Starting {_name} activity for {_duration} seconds...");
    }
}
