using System;

using System;

namespace Develop05
{

    public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _bonusPoints;
        private int _currentCount;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonusPoints = bonusPoints;
            _currentCount = 0;
        }

        public ChecklistGoal(string name, string description, int points,
                             int targetCount, int bonusPoints,
                             int currentCount, bool isComplete)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonusPoints = bonusPoints;
            _currentCount = currentCount;
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            _currentCount = _currentCount + 1;
            int totalPoints = GetPoints();

            if (_currentCount >= _targetCount && !_isComplete)
            {
                _isComplete = true;
                totalPoints = totalPoints + _bonusPoints;
                Console.WriteLine("Congratulations! You have completed this checklist goal!");
                Console.WriteLine("You earned an extra bonus of " + _bonusPoints + " points.");
            }

            return totalPoints;
        }

        public override string GetStatusString()
        {
            string checkbox = _isComplete ? "[X]" : "[ ]";
            string text = checkbox + " " + GetName() + " (" + GetDescription() + ") " +
                          " -- Completed " + _currentCount + "/" + _targetCount + " times";
            return text;
        }

        public override string GetStringRepresentation()
        {
          
            string line = "ChecklistGoal|" + GetName() + "|" + GetDescription() + "|" +
                          GetPoints().ToString() + "|" + _targetCount.ToString() + "|" +
                          _bonusPoints.ToString() + "|" + _currentCount.ToString() + "|" +
                          _isComplete.ToString();
            return line;
        }
    }
}
