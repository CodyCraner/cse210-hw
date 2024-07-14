class GoalSystem
{

    public GoalSystem()
    {

    }

    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal \nWhich type of goal would you like to create?:  ");
        int userOption = int.Parse(Console.ReadLine());

        Console.Write("Name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Short description: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Points when accomplished: ");
        int goalPoints = int.Parse(Console.ReadLine());

        if(userOption == 1)
        {
            string simpleGoal = $"{goalName} {goalDescription} {goalPoints}";
        }
        else if(userOption == 2)
        {
            string eternalGoal = $"{goalName} {goalDescription} {goalPoints}";
        }
        else if(userOption == 3)
        {
            string checklistGoal = $"{goalName} {goalDescription} {goalPoints}";
        }

    }



}