using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference for the scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create the scripture with the reference and text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Main loop to display and hide scripture words
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture); // Display the scripture
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit."); // Prompt user

            // Read user input
            string input = Console.ReadLine();

            // Exit if user types 'quit'
            if (input.ToLower() == "quit") break;

            // Hide a few random words in the scripture
            scripture.HideRandomWords(3);

            // End loop if all words are hidden
            if (scripture.AllWordsHidden()) break;
        }

        // Clear the console and display the final scripture state
        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
