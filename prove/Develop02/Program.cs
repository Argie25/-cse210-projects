using System;


class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Welcome to the Journl Program!");
        int number;
        // Create a new Journal instance outside the loop
        Journal journal = new Journal();
        do{
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            System.Console.Write("What would you like to do: ");
            string sInput = Console.ReadLine();
            number = int.Parse(sInput);

            if (number == 1)
            {
                
                // Create a new Entry instance
                Entry newEntry = new Entry();
                
                // Add an entry to the journal
                journal.AddEntry(newEntry);
            }

            else if (number == 2)
            {
                journal.DisplayAll();
            }

            else if (number == 3)
            {
                Console.Write("Name of the file: ");
                journal.LoadFromFile("Filename");
            }

            else if (number == 4)
            {
                Console.Write("Name of the file: ");
                journal.SaveToFile("filename");
            }

        } while ( number != 5);
    }
}