using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator=new Random();
        int wonderNumber=randomgenerator.Next(1, 101);

        int guess=-1;
        while(guess != wonderNumber)
        {
            Console.Write("What is your guess number ?");
            guess=int.Parse(Console.ReadLine());

            if(wonderNumber>guess)
            {
                Console.WriteLine("Higer");
            }
            else if (wonderNumber<guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.Write("You guess right thank you for playing");
            }








        }
    }
}