public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return Speed > 0 ? 60 / Speed : 0;
    }

    protected override string GetSummaryDetails()
    {
        return $"{base.GetSummaryDetails()}, Speed: {Speed} mph";
    }
}
