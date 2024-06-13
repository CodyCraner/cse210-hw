using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Hello World!");

    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string fullName = Console.ReadLine();
        return fullName;

    }
     static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int favoriteNumber = Int32.Parse(Console.ReadLine());
        return favoriteNumber;

    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {squaredNumber}");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        string fullName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(fullName, squaredNumber);

        

    }
}