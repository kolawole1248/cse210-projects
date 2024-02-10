using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int userScore = 0;

    public void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter the value of the goal: ");
        int goalValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalTypeChoice = Console.ReadLine();

        Goal newGoal;

        switch (goalTypeChoice)
        {
            case "1":
                newGoal = new Goal { Name = goalName, Value = goalValue };
                break;
            case "2":
                newGoal = new EternalGoal { Name = goalName, Value = goalValue };
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the checklist goal: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal { Name = goalName, Value = goalValue, TargetCount = targetCount, Bonus = bonus };
                break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                newGoal = new Goal { Name = goalName, Value = goalValue };
                break;
        }

        goals.Add(newGoal);
        Console.WriteLine($"Goal '{goalName}' created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record an event:");
        DisplayGoals();

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available. Create a goal first.");
            return;
        }

        Console.Write("Enter the index of the goal: ");
        int goalIndex = int.Parse(Console.ReadLine());

        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal selectedGoal = goals[goalIndex];
        selectedGoal.RecordEvent();

        userScore += selectedGoal.Value;

        if (selectedGoal.IsComplete && selectedGoal is ChecklistGoal checklistGoal)
        {
            userScore += checklistGoal.Bonus;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("===== Goals List =====");
        for (int i = 0; i < goals.Count; i++)
        {
            string completionStatus = goals[i].IsComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {completionStatus} {goals[i].Name}");
        }
        Console.WriteLine("=======================");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {userScore} points");
    }

    public void SaveGoals()
    {
        // Implement saving goals to a file
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file
        Console.WriteLine("Goals loaded successfully!");
    }
}
