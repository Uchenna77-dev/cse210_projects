using System;

    class Cycling : Activity
    {
        private double speed;  

        public Cycling(DateTime Date, double Minutes, double Speed)
            : base(Date, Minutes)
        {
            speed = Speed;
        }

        public override double GetSpeed() => speed;

        public override double GetDistance()
        {
            return (speed * Minutes) / 60;
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? Minutes / distance : 0;
        }
    }