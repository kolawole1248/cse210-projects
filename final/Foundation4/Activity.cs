public class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({LengthInMinutes} min) - {GetSummaryDetails()}";
    }

    protected virtual string GetSummaryDetails()
    {
        return $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}
