public class Goal
{
    protected string _name;
    protected int _value;
    protected bool _isComplete;

    public Goal(string name)
    {
        _name = name;
        _value = 0;
        _isComplete = false;
    }

    public virtual void RecordEvent()
    {
        
        _value += 100;
        _isComplete = true;
    }

    public virtual string GetDetailsString()
    {
        
        return $"{_name}: {_value} points";
    }

    
}
