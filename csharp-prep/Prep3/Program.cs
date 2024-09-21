using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int intmagic = randomGenerator.Next(1, 101);
        
        int intguess = -1;
        while (intmagic != intguess)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            intguess = int.Parse(guess);
            if (intguess > intmagic)
            {
                Console.WriteLine("Lower");
            }

            else if (intguess < intmagic)
            {
                Console.WriteLine("Higher");
            }

            else if (intguess == intmagic)
            {
                Console.WriteLine("You guessed it!");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

        }


    }
}