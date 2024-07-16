using System;
using System.Collections.Generic;

namespace EventPlanning
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");
            Address address3 = new Address("789 Pine Road", "Vancouver", "BC", "Canada");

            // Create events and set their values
            Event lecture = new Lecture("C# Advanced Techniques", "A deep dive into advanced C# topics", new DateTime(2024, 8, 15), "10:00 AM", address1, "Dr. John Doe", 100);
            Event reception = new Reception("Networking Reception", "An opportunity to network with industry professionals", new DateTime(2024, 9, 10), "6:00 PM", address2, "rsvp@example.com");
            Event outdoorGathering = new OutdoorGathering("Summer Picnic", "An outdoor picnic with food and games", new DateTime(2024, 7, 20), "12:00 PM", address3, "Sunny");

            // Store the events in a list
            List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

            // Iterate through the list of events and display marketing messages for each
            foreach (Event ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine("\nFull Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("\nShort Description:");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
            }
        }
    }
}
