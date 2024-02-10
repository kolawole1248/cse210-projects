public class ChecklistGoal : Goal
{
    public int CompletionCount { get; set; }
    public int TargetCount { get; set; }
    public int Bonus { get; set; }

    public override void RecordEvent()
    {
        base.RecordEvent();
        CompletionCount++;

        if (IsComplete)
        {
            Console.WriteLine($"You completed the checklist goal: {Name}");
            Console.WriteLine($"You gained {Value} points and a bonus of {Bonus} points.");
        }
        else
        {
            Console.WriteLine($"You recorded an event for the checklist goal: {Name}");
            Console.WriteLine($"You gained {Value} points. Keep going!");
        }
    }
}
