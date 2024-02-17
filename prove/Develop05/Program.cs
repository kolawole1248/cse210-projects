
using System;
using System.Threading;

namespace GoalTracker
{
    public class Program
    {
        private static List<Goal> _goals = new List<Goal>();

        private static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                DisplayGoalsAndScore();

                Console.WriteLine(
@"Menu Options: 
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Event
6. Quit
Select a choice from the menu: ");
                int choice = Program.SafeParse();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        DisplayGoalsAndScore();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void CreateGoal()
        {
            Console.WriteLine(
@"The types of goals are:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
Enter your choice: ");
            int choice = SafeParse();

            switch (choice)
            {
                case 1:
                    _goals.Add(new SimpleGoal());
                    break;
                case 2:
                    _goals.Add(new EternalGoal());
                    break;
                case 3:
                    _goals.Add(new ChecklistGoal());
                    break;
                default:
                    Console.WriteLine("Invalid choice. Goal creation cancelled.");
                    break;
            }
        }

        public static bool AreThereGoalsToRecordEventsFor()
        {
            foreach (Goal goal in _goals)
            {
                if (!goal.IsComplete())
                    return true;
            }
            return false;
        }

        public static int DisplayGoalsThatAreNotYetCompleteAndReturnMaxIndex()
        {
            int index = 1;
            foreach (Goal goal in _goals)
            {
                if (!goal.IsComplete())
                    Console.WriteLine($"{index++}. {goal.GetName()}");
            }
            return index - 1;
        }

        public static Goal GetGoalToCompleteFromOneBasedIndex(int indexToSelect)
        {
            int index = 1;
            foreach (Goal goal in _goals)
            {
                if (!goal.IsComplete())
                {
                    if (index == indexToSelect)
                        return goal;
                    index++;
                }
            }
            return null;
        }

        private static void RecordEvent()
        {
            if (!AreThereGoalsToRecordEventsFor())
            {
                Console.WriteLine("There are no goals available to record events for.");
                return;
            }

            int choice = 0;
            int maxIndex = -1;
            while (choice <= 0 || choice > maxIndex)
            {
                Console.WriteLine("The goals available to complete are:");
                maxIndex = DisplayGoalsThatAreNotYetCompleteAndReturnMaxIndex();

                Console.WriteLine("Which goal did you accomplish? ");
                choice = SafeParse();
            }

            Goal theGoalToComplete = GetGoalToCompleteFromOneBasedIndex(choice);
            System.Diagnostics.Debug.Assert(theGoalToComplete != null);
            theGoalToComplete.Complete();
        }

        private static void DisplayGoalsAndScore()
        {
            Console.Clear();

            int score = 0;
            if (_goals.Count > 0)
            {
                Console.WriteLine("The goals are:");
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine(goal.GetCompleteDisplayString());
                    score += goal.GetPointsEarned();
                }
            }
            else
            {
                Console.WriteLine("No goals have been created or loaded yet.");
            }

            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine();
        }

        private static void SaveGoals()
        {
            Console.Write("Enter Filename to save to: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetType().FullName); 
                    goal.WriteToStreamWriter(writer);
                }
            }
        }

        private static void LoadGoals()
        {
           Console.Write("Enter filename to load from: ");
           string filename = Console.ReadLine();
           _goals.Clear();

           using (StreamReader reader = new StreamReader(filename))
           {
                while (!reader.EndOfStream)
                {
                    string typeLine = reader.ReadLine(); 
                    switch (typeLine)
                    {
                        case "GoalTracker.SimpleGoal":
                            _goals.Add(new SimpleGoal(reader));
                            break;
                        case "GoalTracker.ChecklistGoal":
                            _goals.Add(new ChecklistGoal(reader));
                            break;
                        case "GoalTracker.EternalGoal":
                            _goals.Add(new EternalGoal(reader));
                            break;
                        default:
                            new Exception("Unknown type found in file");
                            break;
                    }
                }
           }
        }

        public static int SafeParse() 
        {
            int result = 0;
            try
            {
                result = int.Parse(Console.ReadLine());                
            }
            catch (System.FormatException)
            {
                return 0; 
            }
            catch (Exception)
            {
                throw; 
            }
            
            return result;
        }
    }
}