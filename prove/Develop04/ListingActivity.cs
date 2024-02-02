// File: ListingActivity.cs
public class ListingActivity : MindfulnessActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "Helps you reflect on positive aspects by listing things in a certain area.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine(listingPrompts[new Random().Next(listingPrompts.Length)]);
        Pause(3);

        Console.WriteLine("Begin listing items...");
        Pause(duration);
        Console.WriteLine($"You listed {duration} items.");
        EndActivity();
    }
}
