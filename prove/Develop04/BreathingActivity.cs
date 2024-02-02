// File: BreathingActivity.cs
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "Helps you relax by guiding you through deep breathing.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Pause(1);
        }
        EndActivity();
    }
}
