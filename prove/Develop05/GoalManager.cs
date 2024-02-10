using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals;
    private int userScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        userScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"New goal added: {goal.Name}");
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        userScore += goal.Value;

        if (goal.IsComplete)
            userScore += (goal as ChecklistGoal)?.Bonus ?? 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"User Score: {userScore}");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            string completionStatus = goal.IsComplete ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{completionStatus} {goal.Name} - Completed {checklistGoal.CompletionCount}/{checklistGoal.TargetCount} times");
            }
            else
            {
                Console.WriteLine($"{completionStatus} {goal.Name}");
            }
        }
    }
}
