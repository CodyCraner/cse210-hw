using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int listingCount = 0;
        int reflectingCount = 0;

        bool programActive = true;

        while(programActive)
        {
            Console.WriteLine("Menu options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Activity Log\n5. Quit");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActivity();
                    breathingCount  += 1;
                    break;

                case 2:
                ReflectingActivty reflecting = new ReflectingActivty();
                    reflecting.StartActivity();
                    reflectingCount += 1;
                    break;
                
                case 3:
                    LisitingActivity listing = new LisitingActivity();
                    listing.StartActivity();
                    listingCount += 1;
                    break;
                    
                
                case 4:
                    Console.WriteLine("Activity - Number of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breathingCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingCount} times");
                    Console.WriteLine($"Listing Activity: {listingCount} times");
                    break;
                
                case 5:
                    Console.WriteLine("Thank you for using the Mindfulness Application! Have a Great Day!");
                    programActive = false;
                    break;
                    

            }

        }
    }
}