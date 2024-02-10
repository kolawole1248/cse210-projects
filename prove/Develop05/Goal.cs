public class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsComplete { get; set; }

    public virtual void RecordEvent()
    {
        IsComplete = true;
    }
}
