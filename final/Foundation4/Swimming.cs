public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() > 0 ? GetDistance() / (LengthInMinutes / 60.0) : 0;
    }

    public override double GetPace()
    {
        return GetDistance() > 0 ? LengthInMinutes / GetDistance() : 0;
    }

    protected override string GetSummaryDetails()
    {
        return $"{base.GetSummaryDetails()}, Distance: {GetDistance()} km, Laps: {Laps}";
    }
}
