public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Implementation here
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        // Customize this to match the format used for saving goals in a file.
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}