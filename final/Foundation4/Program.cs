using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities and set their values
            Activity running = new Running(new DateTime(2024, 7, 15), 30, 4.8); // 4.8 km
            Activity cycling = new Cycling(new DateTime(2024, 7, 16), 45, 20); // 20 kph
            Activity swimming = new Swimming(new DateTime(2024, 7, 17), 60, 30); // 30 laps

            // Store the activities in a list
            List<Activity> activities = new List<Activity> { running, cycling, swimming };

            // Iterate through the list of activities and display their summaries
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}
