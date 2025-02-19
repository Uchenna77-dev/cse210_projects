using System;

class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime Date, double Minutes, int Laps)
            : base(Date, Minutes)
        {
            laps = Laps;
        }

        public override double GetDistance()
        {
            double km = (laps * 50) / 1000.0;
            return km * 0.62;
        }

        public override double GetSpeed()
        {
            double distance = GetDistance();
            return (distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? Minutes / distance : 0;
        }
    }
