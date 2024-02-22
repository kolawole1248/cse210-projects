public class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance > 0 ? Distance / (LengthInMinutes / 60.0) : 0;
    }

    public override double GetPace()
    {
        return Distance > 0 ? LengthInMinutes / Distance : 0;
    }

    protected override string GetSummaryDetails()
    {
        return $"{base.GetSummaryDetails()}, Distance: {Distance} miles";
    }
}
