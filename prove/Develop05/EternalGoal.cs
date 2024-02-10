public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {Name} (+{Value} points)");
    }
}
