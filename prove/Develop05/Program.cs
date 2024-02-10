class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        Goal marathonGoal = new SimpleGoal("Run a Marathon", 1000);
        Goal scripturesGoal = new EternalGoal("Read Scriptures", 100);
        Goal templeGoal = new ChecklistGoal("Attend the Temple", 50, 10, 500);

        goalManager.AddGoal(marathonGoal);
        goalManager.AddGoal(scripturesGoal);
        goalManager.AddGoal(templeGoal);

        goalManager.RecordEvent(marathonGoal);
        goalManager.RecordEvent(scripturesGoal);
        goalManager.RecordEvent(templeGoal);
        goalManager.RecordEvent(templeGoal);

        goalManager.DisplayScore();
        goalManager.DisplayGoals();
    }
}
