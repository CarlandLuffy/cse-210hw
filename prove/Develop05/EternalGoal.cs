using System;

namespace Develop05
{   
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
       
            return GetPoints();
        }

        public override string GetStatusString()
        {
            string text = "[ ] " + GetName() + " (" + GetDescription() + ") (Eternal)";
            return text;
        }

        public override string GetStringRepresentation()
        {
           
            string line = "EternalGoal|" + GetName() + "|" + GetDescription() + "|" +
                          GetPoints().ToString();
            return line;
        }
    }
}
