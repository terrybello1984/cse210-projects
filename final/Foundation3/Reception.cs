using System;

namespace EventPlanning
{
    // Class to represent a reception event
    public class Reception : Event
    {
        // Private member variable for reception-specific details
        private string _rsvpEmail;

        // Constructor to initialize the reception properties
        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        // Override method to return the full details of the reception
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
        }
    }
}
