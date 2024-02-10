using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
    }

    public abstract void RecordEvent();
}
