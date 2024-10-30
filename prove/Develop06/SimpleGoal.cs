public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete) // Check if the goal is not already complete
        {
            _isComplete = true; // Mark the goal as complete
            Console.WriteLine($"Goal '{_shortName}' has been marked as complete.");
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete; // Return the completion status of the goal
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}