using System;

namespace EventPlanning
{
    // Class to represent an outdoor gathering event
    public class OutdoorGathering : Event
    {
        // Private member variable for outdoor gathering-specific details
        private string _weather;

        // Constructor to initialize the outdoor gathering properties
        public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
            : base(title, description, date, time, address)
        {
            _weather = weather;
        }

        // Override method to return the full details of the outdoor gathering
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weather}";
        }
    }
}
