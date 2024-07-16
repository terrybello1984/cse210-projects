using System;

namespace EventPlanning
{
    // Base class to represent a general event
    public abstract class Event
    {
        // Private member variables for event details
        private string _title;
        private string _description;
        private DateTime _date;
        private string _time;
        private Address _address;

        // Constructor to initialize the event properties
        public Event(string title, string description, DateTime date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        // Method to return the standard details of the event
        public string GetStandardDetails()
        {
            return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetAddressString()}";
        }

        // Abstract method to return the full details of the event, to be implemented by derived classes
        public abstract string GetFullDetails();

        // Method to return the short description of the event
        public string GetShortDescription()
        {
            return $"{GetType().Name}: {_title} on {_date.ToShortDateString()}";
        }
    }
}
