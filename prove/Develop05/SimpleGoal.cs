
namespace GoalTracker 
{
    // Simple goal class
    public class SimpleGoal : Goal
    {
        public SimpleGoal() : base()
        {
        }

        public SimpleGoal(StreamReader read) : base(read)
        {
        }

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                _pointsEarned += _pointsForEachCompletion;
            }
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "completion";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "one-time goal";
        }            
    }
}