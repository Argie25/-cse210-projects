public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you showed great resilience.",
        "Recall a moment when you helped someone in need.",
        "Describe an achievement that made you proud.",
        "Reflect on a challenge you faced and overcame.",
        "Think of a time when you had to make a difficult decision.",
        "Recall a moment when you felt truly at peace."
    };
    
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn from this experience?",
        "How did this moment shape who you are today?",
        "What emotions did you feel during this experience?",
        "What would you do differently if faced with a similar situation?",
        "How did this experience affect those around you?"
    };


    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times his activity will help you reflect on times when you successfully overcame challenges or demonstrated strength. Consider the steps you took, the emotions you experienced, the strengths you relied on, and how the experience impacted both you and others." , 0)
    {
        
    }




    public void Run()
    {
        DisplayStartingMessage();
        System.Console.Write("Get Ready");
        ShowSpinner(5);
        System.Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();   
        System.Console.WriteLine("When you have something in your mind, press enter.");
        Console.ReadLine(); 
        System.Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        ShowCountDown(5);

        // Countdown
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            DisplayQuestion();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);  // Generate a random index based on the list size
        return _prompts[index];  // Return the prompt at the random indexreturn "";
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);  // Generate a random index based on the list size
        return _prompts[index];  // Return the question at the random indexreturn "";
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();  // Get a random prompt
        Console.WriteLine($"----- {prompt} -----");  // Display the prompt
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();  // Get a random question
        Console.Write($" > {question}?");  // Display the question
        ShowSpinner(5);
        System.Console.WriteLine();
    }
}