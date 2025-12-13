namespace Foundation4
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            _laps = laps;
        }

      
        public override double GetDistance()
        {
            double kilometers = (double)_laps * 50.0 / 1000.0;
            double miles = kilometers * 0.62;
            return miles;
        }

        public override double GetSpeed()
        {
            double hours = (double)GetLengthMinutes() / 60.0;
            return GetDistance() / hours;
        }

        public override double GetPace()
        {
            double distance = GetDistance();

            if (distance == 0.0)
            {
                return 0.0;
            }

            return (double)GetLengthMinutes() / distance;
        }

        public override string GetSummary()
        {
            return GetDate() + " Swimming (" + GetLengthMinutes() + " min) - " +
                   "Distance: " + GetDistance().ToString("0.00") + " miles, " +
                   "Speed: " + GetSpeed().ToString("0.00") + " mph, " +
                   "Pace: " + GetPace().ToString("0.00") + " min per mile";
        }
    }
}
