using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class ReflectingActivty 
{
     private int _duration;
     private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public ReflectingActivty()
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
        Console.WriteLine("Welcome to the Reflecting Activity \n \n This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
         Console.WriteLine($"The Reflecting activity will start for {duration} seconds...");
        Countdown();
        Console.WriteLine($"---- {PromptGenerator()} ----");
        DisplayQuestion();
        Console.WriteLine($"Great job! You completed Reflecting Activity for {_duration} seconds.");
        Thread.Sleep(2500);
    }
    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string QuestionGenerator()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    private void DisplayQuestion()
    {
        int seconds = _duration;
        while (seconds > 0)
        {
            string question = QuestionGenerator();
            Console.WriteLine(question);
            Countdown();
            seconds -= 3;
        }
    }



}