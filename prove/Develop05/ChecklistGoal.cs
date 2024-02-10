public class ChecklistGoal : Goal
{
    private int completionCount;
    private int targetCount;
    public int Bonus { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
    {
        this.targetCount = targetCount;
        Bonus = bonus;
        completionCount = 0;
    }

    public override void RecordEvent()
    {
        completionCount++;

        Console.WriteLine($"Event recorded for {Name} (+{Value} points)");

        if (completionCount == targetCount)
        {
            Console.WriteLine($"Bonus achieved for completing {Name}! (+{Bonus} points)");
            IsComplete = true;
        }
    }

    // Public properties to access CompletionCount and TargetCount
    public int CompletionCount => completionCount;
    public int TargetCount => targetCount;
}
