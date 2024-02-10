class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Example usage:
        goalManager.AddGoal(new SimpleGoal("Run a marathon"));
        goalManager.AddGoal(new EternalGoal("Read scriptures"));
        goalManager.AddGoal(new ChecklistGoal("Attend the temple", 10));

        goalManager.RecordEvent(0); // Record event for the first goal
        goalManager.RecordEvent(2); // Record event for the third goal

        goalManager.DisplayGoals();
    }
}
