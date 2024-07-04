using System;

// Derived class that implements a listing activity
public class ListingActivity : MindfulnessActivity
{
    // Prompts for the listing activity
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor that sets the name and description of the activity
    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // Implementation of the abstract method RunActivity
    protected override void RunActivity()
    {
        Random random = new Random(); // Create an instance of Random

        // Select a random prompt and display it
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int elapsed = 0; // Variable to track the elapsed time
        int itemCount = 0; // Counter for the number of items

        // Loop that continues until the elapsed time reaches the specified duration
        while (elapsed < Duration)
        {
            // Prompt the user to enter an item
            Console.Write("Enter an item: ");
            Console.ReadLine();
            // Increment the item counter
            itemCount++;
            // Increment the elapsed time
            elapsed += 3;
        }

        // Display the total number of items entered
        Console.WriteLine($"You listed {itemCount} items.");
    }
}
