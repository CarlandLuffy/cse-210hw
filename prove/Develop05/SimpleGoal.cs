using System;

namespace Develop05
{

    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public SimpleGoal(string name, string description, int points, bool isComplete)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return GetPoints();
            }
            else
            {
                Console.WriteLine("This simple goal is already completed. No additional points.");
                return 0;
            }
        }

        public override string GetStringRepresentation()
        {
            
            string line = "SimpleGoal|" + GetName() + "|" + GetDescription() + "|" +
                          GetPoints().ToString() + "|" + _isComplete.ToString();
            return line;
        }
    }
}
