namespace Foundation4
{
    public class Cycling : Activity
    {
        private double _speedMPH;

        public Cycling(string date, int lengthMinutes, double speedMPH)
            : base(date, lengthMinutes)
        {
            _speedMPH = speedMPH;
        }

        public override double GetDistance()
        {
            double hours = (double)GetLengthMinutes() / 60.0;
            return _speedMPH * hours;
        }

        public override double GetSpeed()
        {
            return _speedMPH;
        }

        public override double GetPace()
        {
            return 60.0 / _speedMPH;
        }

        public override string GetSummary()
        {
            return GetDate() + " Cycling (" + GetLengthMinutes() + " min) - " +
                   "Distance: " + GetDistance().ToString("0.00") + " miles, " +
                   "Speed: " + GetSpeed().ToString("0.00") + " mph, " +
                   "Pace: " + GetPace().ToString("0.00") + " min per mile";
        }
    }
}
