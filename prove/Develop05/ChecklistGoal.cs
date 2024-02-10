public class ChecklistGoal : Goal
{
    private int _completionCount;
    private int _targetCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        _completionCount = 0;
        _targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        
        _completionCount++;
        _value += 50;

        if (_completionCount == _targetCount)
        {
            _value += 500; 
            _isComplete = true;
        }
    }

    public override string GetDetailsString()
    {
        // Override the GetDetailsString method for checklist goals
        return $"{_name}: Completed {_completionCount}/{_targetCount} times - {_value} points";
    }

    // Additional methods or properties as needed
}
