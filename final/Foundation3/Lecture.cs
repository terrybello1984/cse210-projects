using System;

namespace EventPlanning
{
    // Class to represent a lecture event
    public class Lecture : Event
    {
        // Private member variables for lecture-specific details
        private string _speaker;
        private int _capacity;

        // Constructor to initialize the lecture properties
        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        // Override method to return the full details of the lecture
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        }
    }
}
