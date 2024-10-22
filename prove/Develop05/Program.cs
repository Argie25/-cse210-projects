using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        do {
            Console.Clear();
            System.Console.WriteLine("Menu option: ");
            System.Console.WriteLine("1. Start breathing activity");
            System.Console.WriteLine("2. Start reflecting activity");
            System.Console.WriteLine("3. Start listing activity");
            System.Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number == 1)
            {
                var a2 = new BreathingActivity();
                a2.Run();
            }

            else if (number == 2)
            {
                var a2 = new ReflectingActivity();
                a2.Run();
            }

            else if (number == 3)
            {
                var a3 = new ListingActivity();
                a3.Run();
            }

        } while (number != 4);
    }

    private static object ListingActivity()
    {
        throw new NotImplementedException();
    }
}