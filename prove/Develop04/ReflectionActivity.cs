// File: ReflectionActivity.cs
public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection", "Helps you reflect on times when you demonstrated strength and resilience.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Pause(1);

            // Ask reflection questions
            Console.WriteLine("Reflection Questions:");
            AskReflectionQuestions();
        }
        EndActivity();
    }

    private void AskReflectionQuestions()
    {
        string[] reflectionQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Pause(3);
        }
    }
}
