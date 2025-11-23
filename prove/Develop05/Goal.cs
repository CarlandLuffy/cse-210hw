using System;

namespace Develop05
{
    public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _points;
        protected bool _isComplete;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
            _isComplete = false;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }

        public bool IsComplete()
        {
            return _isComplete;
        }

        public virtual string GetStatusString()
        {
            string checkbox = _isComplete ? "[X]" : "[ ]";
            return checkbox + " " + _name + " (" + _description + ")";
        }

        public abstract int RecordEvent();

        public abstract string GetStringRepresentation();
    }
}
