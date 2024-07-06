class BreathingActivity
{
    private int _duration;

    public BreathingActivity()
    {

    }

    public void Countdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"\r{i}...");
            Thread.Sleep(1100);
        }
        Console.WriteLine();
    }
    public void StartActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity \n \n This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ");

        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

         Console.WriteLine($"The Reflecting activity will start for {duration} seconds...");
         Countdown();


         bool breatheIn = true;
        while (duration > 0)
        {
            if (breatheIn)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            Countdown();
            breatheIn = !breatheIn;
            duration = duration - 3;
        }

        Console.WriteLine($"Great job! You completed Breathing Activity for {_duration} seconds.");
        Thread.Sleep(2500);
    }
}