using System;

class Program
{
    static void Main(string[] args)
    {
        int NumberOfGuesses = 0;
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int guessedNumber = 0;

        while (randomNumber != guessedNumber)
        {
            Console.WriteLine("What is your guess?");
            guessedNumber = int.Parse(Console.ReadLine());
            NumberOfGuesses ++;

            if (guessedNumber == randomNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You got it in {NumberOfGuesses} guesses!! ");
            }

            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }

        }
    }    
}