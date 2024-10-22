public class Activity
{
    protected string _name;
    protected string _discription;
    protected int _duration;

    public Activity(string name, string discription, int duration)
    {
        _name = name;
        _discription = discription;
        _duration = duration;
    }

    public Activity()
    {
        _name = "Default Activity";
        _discription = "This is a default activity description.";
        _duration = 0; // Default value
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        System.Console.WriteLine(_discription);
        System.Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        _duration = int.Parse(time);
        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        System.Console.WriteLine("Well done!");
        ShowCountDown(5);
        System.Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowCountDown(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            System.Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
    }

    
}