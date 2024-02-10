public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine($"You gained {Value} points for completing the simple goal: {Name}");
    }
}
