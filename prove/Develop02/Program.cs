using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Boolean completion = false;
        Console.WriteLine("Welcome to the Journal Program");

        while(completion == false)
        {
            Console.WriteLine("Please select one of the following Choices \n 1. Write \n 2. Recreate Entry \n 3. Display \n 4. Load \n 5. Save \n 6. Exitou ");
            Console.WriteLine("What would you like to do?");
            int userChoice = Int32.Parse(Console.ReadLine());

            if(userChoice == 1)
            {
                myJournal.AddEntry();
            }
            else if(userChoice == 2)
            {
                myJournal.Display();
                Console.WriteLine("Which entry would you like to recreate?: ");
                int newEntry = Int32.Parse(Console.ReadLine());
                myJournal.editEntry(newEntry);
                
            }
            else if(userChoice == 3)
            {
                myJournal.Display();

            }
            else if(userChoice == 4)
            {
                Console.WriteLine("Enter the file name of the Journal to load: ");
                string journalFile = Console.ReadLine();
                myJournal.ReadFromFile(journalFile);
            }
            else if(userChoice == 5)
            {
                Console.WriteLine("Enter a name for the Journal file: ");
                string journalName = Console.ReadLine();
                myJournal.WriteToFile(journalName);
            }
            else if(userChoice == 6)
            {
                Console.WriteLine("I hope you enjoyed Journaling, Have a Great Day!");
                completion = true;
            }
        }
    }
}