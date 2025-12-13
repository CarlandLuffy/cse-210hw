namespace Foundation4
{
    public class Running : Activity
    {
        private double _distanceMiles;

        public Running(string date, int lengthMinutes, double distanceMiles)
            : base(date, lengthMinutes)
        {
            _distanceMiles = distanceMiles;
        }

        public override double GetDistance()
        {
            return _distanceMiles;
        }

        public override double GetSpeed()
        {
            double hours = (double)GetLengthMinutes() / 60.0;
            return _distanceMiles / hours;
        }

        public override double GetPace()
        {
            return (double)GetLengthMinutes() / _distanceMiles;
        }

        public override string GetSummary()
        {
            return GetDate() + " Running (" + GetLengthMinutes() + " min) - " +
                   "Distance: " + GetDistance().ToString("0.00") + " miles, " +
                   "Speed: " + GetSpeed().ToString("0.00") + " mph, " +
                   "Pace: " + GetPace().ToString("0.00") + " min per mile";
        }
    }
}
