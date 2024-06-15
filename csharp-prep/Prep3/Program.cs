using System;

class Program
{
    static void Main(string[] args)
    {
        string response; 

        do
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 1 is inclusive, 101 is exclusive

            // Add a loop that keeps looping as long as the guess does not match the magic number
            int guess = 0;
            int numberOfGuess = 0;

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Increment the number of guesses
                numberOfGuess++;

                // Determine if the user needs to guess higher or lower next time, or tell them if they guessed it
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("You gueesed it!");
                }
            }
            // Inform the user how many guesses it took
            Console.WriteLine($"It took you {numberOfGuess} guesses.");
            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
        
    }
}