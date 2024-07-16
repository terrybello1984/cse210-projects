using System;

namespace ExerciseTracking
{
    // Base class to represent a general activity
    public abstract class Activity
    {
        // Private member variables for activity details
        private DateTime _date;
        private int _lengthMinutes;

        // Constructor to initialize the activity properties
        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        // Getters for the common properties
        public DateTime Date => _date;
        public int LengthMinutes => _lengthMinutes;

        // Virtual methods to be overridden in derived classes
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Method to return a summary of the activity
        public virtual string GetSummary()
        {
            return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthMinutes} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }
}
