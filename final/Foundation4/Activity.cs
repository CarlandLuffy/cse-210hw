namespace Foundation4
{
    public class Activity
    {
        private string _date;
        private int _lengthMinutes;

        public Activity(string date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public string GetDate()
        {
            return _date;
        }

        public int GetLengthMinutes()
        {
            return _lengthMinutes;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return _date + " Activity (" + _lengthMinutes + " min) - " +
                   "Distance: " + GetDistance().ToString("0.00") + " miles, " +
                   "Speed: " + GetSpeed().ToString("0.00") + " mph, " +
                   "Pace: " + GetPace().ToString("0.00") + " min per mile";
        }
    }
}
