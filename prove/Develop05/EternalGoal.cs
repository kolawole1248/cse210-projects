public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine($"You gained {Value} points for your eternal goal: {Name}");
    }
}
