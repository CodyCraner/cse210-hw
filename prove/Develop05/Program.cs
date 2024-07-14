using System;

class Program
{
    static void Main(string[] args)
    {
        GoalSystem system = new GoalSystem();

        Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect any option: ");
        int userOption = int.Parse(Console.ReadLine());

        switch(userOption)
        {
            case 1:
                system.CreateNewGoal();
                break;

            case 2:
                Console.WriteLine("");
                break;

            case 3:
                Console.WriteLine("");
                break;

            case 4:
                Console.WriteLine("");
                break;

            case 5:
                Console.WriteLine("");
                break;

            case 6:
                Console.WriteLine("");
                break;
        }
    }
}