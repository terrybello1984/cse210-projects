using System;

namespace ExerciseTracking
{
    // Class to represent a cycling activity
    public class Cycling : Activity
    {
        // Private member variable for cycling-specific details
        private double _speed;

        // Constructor to initialize the cycling properties
        public Cycling(DateTime date, int lengthMinutes, double speed)
            : base(date, lengthMinutes)
        {
            _speed = speed;
        }

        // Override method to return the distance
        public override double GetDistance()
        {
            return (_speed * LengthMinutes) / 60;
        }

        // Override method to return the speed
        public override double GetSpeed()
        {
            return _speed;
        }

        // Override method to return the pace
        public override double GetPace()
        {
            return 60 / _speed;
        }
    }
}
