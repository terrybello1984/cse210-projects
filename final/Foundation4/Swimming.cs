using System;

namespace ExerciseTracking
{
    // Class to represent a swimming activity
    public class Swimming : Activity
    {
        // Private member variable for swimming-specific details
        private int _laps;

        // Constructor to initialize the swimming properties
        public Swimming(DateTime date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        // Override method to return the distance
        public override double GetDistance()
        {
            return (_laps * 50) / 1000.0;
        }

        // Override method to return the speed
        public override double GetSpeed()
        {
            return (GetDistance() / LengthMinutes) * 60;
        }

        // Override method to return the pace
        public override double GetPace()
        {
            return LengthMinutes / GetDistance();
        }
    }
}
