using System;

// Main class of the program
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Clear the console
            Console.Clear();
            // Display the main menu
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            // Prompt the user to select an activity
            Console.Write("Select an activity: ");
            string choice = Console.ReadLine();

            // Declare a variable of type MindfulnessActivity
            MindfulnessActivity activity = null;

            // Assign the selected activity to the variable
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    // Exit the program
                    return;
                default:
                    // Display an error message if the choice is invalid
                    Console.WriteLine("Invalid choice. Try again.");
                    ShowSpinner(2);
                    continue;
            }

            // Start the selected activity
            activity.StartActivity();
        }
    }

    // Method to show a spinner for a specified number of seconds
    static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            // Display a dot
            Console.Write(".");
            // Pause for 1 second
            System.Threading.Thread.Sleep(1000);
        }
        // Add a new line after the spinner
        Console.WriteLine();
    }
}
