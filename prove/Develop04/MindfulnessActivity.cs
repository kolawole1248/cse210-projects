using System;
using System.Threading;

// File: MindfulnessActivity.cs
public class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {name} activity. {description}");
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You have spent {duration} seconds on {name}.");
        Pause(3);
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(". ");
        }
        Console.WriteLine();
    }
}
