using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            string guess = "";
            int guessNum = 0;
            
            int guessCount = 0;
            Console.WriteLine($"The number is: {theNumber}");

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

            do {
                guess = Console.ReadLine();
                bool isNumber = int.TryParse(guess, out guessNum);
                if (isNumber && guessNum >= 0 && guessNum <= 20) {
                    guessCount++;
                    Console.WriteLine("Guess again! Your guess count is: " + guessCount);
                } else if (guessNum == -1) {
                    break;
                } else if (guessNum < 0 || guessNum > 20) {
                    Console.WriteLine("Your guess is too low/high. Please guess between 0 and 20");
                } else if (!isNumber) {
                    Console.WriteLine("Oops! Please guess a number 0 through 20.");
                }
            }
            while (guessNum != theNumber);

            if (guessNum != -1) {
                Console.WriteLine($"Congrats! You guessed the correct number in {guessCount} attempts!");
            }
        }
    }
}
