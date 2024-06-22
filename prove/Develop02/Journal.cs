using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<entry> entries;
    public List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

    


    public Journal()
    {
        entries = new List<entry>();
    }
    public string RandomPrompt(List<string> prompts)
    {
        Random r = new Random();
        int randomPostion = r.Next(prompts.Count);
        //obtained from Stack Overflow
        string prompt = prompts[randomPostion];   
        return prompt;
    }

    public void AddEntry()
    {
        string prompt = RandomPrompt(prompts);
        Console.WriteLine(prompt);
        string userResponse = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        //Used chat gpt for the syntax in DateTime call
        entries.Add(new entry(prompt, userResponse, date));
    }

    public void Display()
    {
        foreach(entry entry in entries)
        {
            
            Console.WriteLine(entry.ToString());
        }
    }
    public void editEntry(int entryNumber)  
    {
        Console.WriteLine(entries[entryNumber]);
        entries.RemoveAt(entryNumber);
        Console.WriteLine("Enter desired updates in new entry: ");
        AddEntry();
        
    }
    public void ReadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines )
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            entry entry = new entry(date, question, entryText);

        }

    }

    public void WriteToFile(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(entry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }

        }
    }
    

}