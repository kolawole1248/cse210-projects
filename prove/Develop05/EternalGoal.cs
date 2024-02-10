public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name)
    {
        
    }

    public override void RecordEvent()
    {
        
        _value += 100;
    }

    
}
