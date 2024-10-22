public class ListingActivity : Activity
{
    private int _count;
    public List<string> _prompts = new List<string>()
    {
        "List the things you are grateful for today.",
        "What are your top goals for the week?",
        "List the skills you want to improve.",
        "What are your favorite hobbies and why?",
        "Who are the people who inspire you the most?",
        "List the things that make you feel productive.",
        "What challenges have you overcome recently?",
        "What are the books or movies that have influenced you?",
        "What are the places you want to visit and why?",
        "List the things that bring you joy."
    };

    public ListingActivity() : base("Reflecting", "This activity will help you reflect on times when you've shown resilience, achieved success, or made a positive impact on others. It will also guide you to recognize moments of personal growth, creativity, and fulfillment from your strengths and passions." , 0)
    {
        _count = 0;
    }


    public void Run()
    {
        DisplayStartingMessage();
        System.Console.WriteLine("List as many responses you can to the following prompts");
        System.Console.WriteLine(GetRandomPrompt());
        System.Console.WriteLine("You may begin in");
        GetListFromUser();
        System.Console.WriteLine($"number of input {_count}");
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);  // Generate a random index based on the list size
        return _prompts[index];  // Return the prompt at the random index

    }

    public int GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);  // Use _duration set by DisplayStartingMessage()

        while (DateTime.Now < endTime)
        {
            Console.Write("Entry: ");  // Prompt for each input
            string input = Console.ReadLine();  // Read the user's input

            if (!string.IsNullOrEmpty(input))  // Validate input
            {
                _count++;  // Increment _count for each valid entry
            }
        }

        return _count;  // Return the updated count
    }

}

