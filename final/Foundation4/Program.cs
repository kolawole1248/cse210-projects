using System;
using System.Collections.Generic;

class ExerciseTrackingProgram
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        Running running = new Running { Date = DateTime.Now, LengthInMinutes = 30, Distance = 3.0 };
        Cycling cycling = new Cycling { Date = DateTime.Now.AddDays(1), LengthInMinutes = 45, Speed = 15.0 };
        Swimming swimming = new Swimming { Date = DateTime.Now.AddDays(2), LengthInMinutes = 60, Laps = 20 };

        // Add activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
