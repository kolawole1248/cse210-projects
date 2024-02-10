using System;

class EternalQuestProgram
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        string userInput;

        do
        {
            DisplayMenu();
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                    break;
            }

        } while (userInput != "7");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("===== Eternal Quest Program =====");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");
        Console.Write("Enter your choice: ");
    }
}
