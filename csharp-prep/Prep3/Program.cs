using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int secret_number = rnd.Next(1, 20);
        Boolean correct = false;
        int totalGuess = 0;
        Console.WriteLine("Welcome to the Number guessing game.");

        while(correct == false)
        {

            Console.WriteLine("Enter a number 1-20: ");
            int guess = Int32.Parse(Console.ReadLine());
            totalGuess++;

            if(guess == secret_number)
            {
                Console.WriteLine("You guessed it correctly!");
                Console.WriteLine($"It took you {totalGuess} tries.");
                correct = true;
            }
            else if (guess > secret_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < secret_number)
            {
                Console.WriteLine("Higher");
            }

        }
    }
}