class LisitingActivity
{

    private int _duration;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private List<string> _listed = new List<string>();

    public LisitingActivity()
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
        Console.WriteLine("Welcome to the Listing Activity \n \n This Activity will help you reflect on good things in your life by having you list as many things as you can in a certain area. ");

        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

         Console.WriteLine($"The Reflecting activity will start for {duration} seconds...");

        Countdown();

        Console.WriteLine($"---- {PromptGenerator()} ----");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                _listed.Add(userInput);
            }
        }

        DisplayListNumber();

        Console.WriteLine($"Great job! You completed Listing Activity for {_duration} seconds.");
        Thread.Sleep(2500);
    }

    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private void DisplayListNumber()
    {
        Console.WriteLine($"You listed {_listed.Count} items.");
        Thread.Sleep(3000);
    }



}