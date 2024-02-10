public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal completed: {Name} (+{Value} points)");
        IsComplete = true;
    }
}
