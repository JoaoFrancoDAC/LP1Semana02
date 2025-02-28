using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            int attempts = 0;

            Console.WriteLine("Insert number:");
            string userGuess = Console.ReadLine();
            int guessedNumber = Convert.ToInt32(userGuess);


            while (guessedNumber != numberToGuess)
            {
                if (guessedNumber < 0 || guessedNumber > 30)
                {
                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    Console.WriteLine("Insert number:");
                    userGuess = Console.ReadLine();
                    guessedNumber = Convert.ToInt32(userGuess);
                    continue;
                }
                
                if (guessedNumber < numberToGuess)
                {
                    Console.WriteLine("The hidden number is greater. Try again.");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("The hidden number is smaller. Try again.");
                    attempts++;
                }
                Console.WriteLine("Insert number:");
                userGuess = Console.ReadLine();
                guessedNumber = Convert.ToInt32(userGuess);
            }

            if (guessedNumber == numberToGuess)
            {
                attempts++;
                Console.WriteLine($"You the hidden number {guessedNumber} after {attempts} tries.");
            }
        }
    }
}
