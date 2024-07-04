using System;

// Derived class that implements a breathing activity
public class BreathingActivity : MindfulnessActivity
{
    // Constructor that sets the name and description of the activity
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Implementation of the abstract method RunActivity
    protected override void RunActivity()
    {
        int elapsed = 0; // Variable to track the elapsed time

        // Loop that continues until the elapsed time reaches the specified duration
        while (elapsed < Duration)
        {
            // Display "Breathe in" message
            Console.WriteLine("Breathe in...");
            // Show a spinner for 3 seconds
            ShowSpinner(3);
            // Increment the elapsed time
            elapsed += 3;

            // Display "Breathe out" message
            Console.WriteLine("Breathe out...");
            // Show a spinner for 3 seconds
            ShowSpinner(3);
            // Increment the elapsed time
            elapsed += 3;
        }
    }
}
