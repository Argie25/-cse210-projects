
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public int AmountCompleted
    {
        get { return _amountCompleted; } // Property to get amount completed
        set { _amountCompleted = value; } // Property to set amount completed
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            // Add bonus points since the goal has been completed.
            Console.WriteLine($"Congratulations! You completed the checklist goal '{_shortName}' and earned {_points + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Progress made! '{_shortName}' now has {_amountCompleted} out of {_target} completions.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} - {_description} (Completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}