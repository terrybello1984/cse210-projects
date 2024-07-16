using System;

namespace ExerciseTracking
{
    // Class to represent a running activity
    public class Running : Activity
    {
        // Private member variable for running-specific details
        private double _distance;

        // Constructor to initialize the running properties
        public Running(DateTime date, int lengthMinutes, double distance)
            : base(date, lengthMinutes)
        {
            _distance = distance;
        }

        // Override method to return the distance
        public override double GetDistance()
        {
            return _distance;
        }

        // Override method to return the speed
        public override double GetSpeed()
        {
            return (_distance / LengthMinutes) * 60;
        }

        // Override method to return the pace
        public override double GetPace()
        {
            return LengthMinutes / _distance;
        }
    }
}
