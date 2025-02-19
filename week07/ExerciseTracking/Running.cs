using System;

    class Running : Activity
    {
        private double distance;  

        public Running(DateTime Date, double Minutes, double Distance)
            : base(Date, Minutes)
        {
            distance = Distance;
        }

        public override double GetDistance() => distance;

        public override double GetSpeed()
        {
            return (distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / distance;
        }
    }