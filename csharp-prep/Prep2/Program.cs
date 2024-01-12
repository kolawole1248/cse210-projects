using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage");
        string answer=Console.ReadLine();
        int percent =int.Parse(answer);

        string rank = "";

        if (percent>=90)
        {
            rank="A";
        }
        else if (percent>=80)
        {
            rank="B";
        }
        else if (percent>=70)
        {
            rank="C";
        }
        else if (percent >=60)
        {
            rank="D";
        }
        else if (percent < 60)
        {
            rank="F";
        }
        else
        {
            rank="F";
        }
        Console.WriteLine($"Your grade is {rank}");
        
        if (percent>=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }



    }
}