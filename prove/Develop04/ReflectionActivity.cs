using System;

// Derived class that implements a reflection activity
public class ReflectionActivity : MindfulnessActivity
{
    // Prompts and questions for the reflection activity
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor that sets the name and description of the activity
    public ReflectionActivity()
    {
        ActivityName = "Reflection Activity";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Implementation of the abstract method RunActivity
    protected override void RunActivity()
    {
        Random random = new Random(); // Create an instance of Random
        int elapsed = 0; // Variable to track the elapsed time

        // Select a random prompt and display it
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        // Loop that continues until the elapsed time reaches the specified duration
        while (elapsed < Duration)
        {
            // Select a random question and display it
            string question = questions[random.Next(questions.Length)];
            Console.WriteLine(question);
            // Show a spinner for 5 seconds
            ShowSpinner(5);
            // Increment the elapsed time
            elapsed += 5;
        }
    }
}
