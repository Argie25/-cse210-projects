public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string ShortName => _shortName;
    public virtual int Points => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName}: {_description}";
    }
    public abstract string GetStringRepresentation();
}