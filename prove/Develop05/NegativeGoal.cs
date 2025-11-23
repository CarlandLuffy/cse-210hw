using System;

namespace Develop05
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public NegativeGoal(string name, string description, int points, bool isComplete)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            Console.WriteLine("Oops, this is a negative habit. You lose " + GetPoints() + " points.");
            
            return -GetPoints();
        }

        public override string GetStatusString()
        {
            string text = "[ ] " + GetName() + " (" + GetDescription() + ") (Negative habit)";
            return text;
        }

        public override string GetStringRepresentation()
        {
            string line = "NegativeGoal|" + GetName() + "|" + GetDescription() + "|" +
                          GetPoints().ToString() + "|" + _isComplete.ToString();
            return line;
        }
    }
}
