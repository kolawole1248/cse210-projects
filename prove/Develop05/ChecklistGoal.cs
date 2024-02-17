
namespace GoalTracker
{
    public class ChecklistGoal : Goal
    {
        private int _numberOfTimesToComplete = 0;
        private int _numberOfTimesCheckedOff = 0;
        private int _completionBonus = 0;

        public ChecklistGoal() : base()
        {
            Console.WriteLine("Enter how many times must the checklist goal be completed for a onus? ");
            _numberOfTimesToComplete = Program.SafeParse();
            Console.WriteLine($"What is the bonus point reward once it is completed {_numberOfTimesToComplete} times? ");
            _completionBonus = Program.SafeParse();
        }

        public ChecklistGoal(StreamReader read) : base(read)
        {
            _numberOfTimesToComplete = int.Parse(read.ReadLine());
            _numberOfTimesCheckedOff = int.Parse(read.ReadLine());
            _completionBonus = int.Parse(read.ReadLine());
        }        

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _numberOfTimesCheckedOff++;
                _pointsEarned += _pointsForEachCompletion;

                if (_numberOfTimesCheckedOff == _numberOfTimesToComplete)
                {
                    _isCompleted = true;
                    _pointsEarned += _completionBonus;
                }
            }
        }

        protected override string GetFriendlyCompleteActionDescription()
        {
            return "each time you accomplish this goal";
        }

        protected override string GetFriendlyGoalTypeName()
        {
            return "checklist goal";
        }

        public override string GetCompleteDisplayString() // spoiler--we marked this virtual in the base class becuase Checklist goal needs to override it.
        {
            return $"{base.GetCompleteDisplayString()} {GetProgressStatus()}";  // base does what we want, call it then add progress status for hecklist goal..
        }

        private string GetProgressStatus()
        {
            return $"Completed {_numberOfTimesCheckedOff}/{_numberOfTimesToComplete} times.";
        }

        public override void WriteToStreamWriter(StreamWriter w)
        {
            base.WriteToStreamWriter(w);
            w.WriteLine(_numberOfTimesToComplete);
            w.WriteLine(_numberOfTimesCheckedOff);
            w.WriteLine(_completionBonus);
        }   
    }
}