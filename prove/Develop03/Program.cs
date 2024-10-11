using System;

class Program
{
    static void Main(string[] args)
    {
        // Store the scripture (e.g., John 3:16 or Proverbs 3:5-6)
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son");

        // Main loop
        while (true)
        {
            // Clear the console
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            // Check if all words are hidden, and if so, end the program
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. The program will now end.");
                break;
            }

            // Prompt the user to press Enter or type 'quit'
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                // End the program if the user types 'quit'
                break;
            }

            // Hide random words if the user presses Enter
            scripture.HideRandomWords(3);  // Hide 3 random words each time
        }
    }
}