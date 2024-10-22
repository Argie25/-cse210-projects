public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and fucos on your breathing." , 0)
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();  
    }
}