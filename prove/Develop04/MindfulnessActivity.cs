using System;
using System.Threading; // Needed to use Thread.Sleep

// Abstract class that acts as a base for mindfulness activities
public abstract class MindfulnessActivity
{
    // Protected properties for the name, description, and duration of the activity
    protected string ActivityName { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    // Public method to start the activity
    public void StartActivity()
    {
        // Clear the console
        Console.Clear();
        // Display the name of the activity
        Console.WriteLine($"Starting {ActivityName}");
        // Display the description of the activity
        Console.WriteLine(Description);
        // Prompt the user to enter the duration in seconds
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        // Instruct the user to prepare to begin
        Console.WriteLine("Prepare to begin...");
        // Show a spinner for 3 seconds
        ShowSpinner(3);

        // Call the abstract method to be implemented in derived classes
        RunActivity();

        // Display a final message indicating the activity has ended
        Console.WriteLine($"Good job! You have completed the {ActivityName} activity for {Duration} seconds.");
        // Show a spinner for 3 seconds
        ShowSpinner(3);
    }

    // Abstract method to be implemented in derived classes
    protected abstract void RunActivity();

    // Method to show a spinner for a specified number of seconds
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            // Display a dot
            Console.Write(".");
            // Pause for 1 second
            Thread.Sleep(1000);
        }
        // Add a new line after the spinner
        Console.WriteLine();
    }
}
