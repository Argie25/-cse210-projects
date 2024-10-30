using System.Reflection.PortableExecutable;

public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();  // Distance calculation varies
    public abstract double GetSpeed();     // Speed calculation varies
    public abstract double GetPace();  


    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F1} min per km";
    }
}