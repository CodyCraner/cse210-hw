using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade: ");
        int grade = 0;
        grade = Int32.Parse(Console.ReadLine());
        //Obtained from stack overflow
        string letterGrade = "Unknown";
        Boolean passed = false;

        if (grade >= 90)
        {
            letterGrade = "A";
            passed = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            passed = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            passed = true;
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You have a {letterGrade}");  
        if (passed == true)
        {
            Console.WriteLine("You Passed!");

        }
        else if (passed == false)
        {
            Console.WriteLine("You did not pass.");
        }

    }
}