using System;
using System.Collections.Generic;

abstract class Activity
    {
        private DateTime date;
        private double minutes;
        public Activity(DateTime Date, double Minutes)
        {
            date = Date;
            minutes = Minutes;
        }

        public DateTime Date => date;
        public double Minutes => minutes;

        public abstract double GetDistance();  
        public abstract double GetSpeed();     
        public abstract double GetPace();      


        public virtual string GetSummary()
        {
            string dateStr = Date.ToString("dd MMM yyyy");
            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();


            return $"{dateStr} {this.GetType().Name} ({Minutes} min) - Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} min per mile";
        }
    }    
    