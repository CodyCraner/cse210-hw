using System;

class Program
{
    static void Main(string[] args)
    {
        string verse;   
        Console.WriteLine("Welcome to the Scripture Mastery Program!\n Please Select One of the Following: ");
        Console.WriteLine("1. 1 Nephi 3:7\n 2. Moroni 10:9-10 \n 3. John 16:7 \n 4. Mosiah 3:17 \n 5. Deuteronomy 6:4-5");
        int newEntry = Int32.Parse(Console.ReadLine());
        

        if(newEntry == 1){
           verse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."; 
        Reference reference = new Reference("Nephi", 3, 7);
        string referenceTitle = reference.CreateReference();
        Scripture scripture = new Scripture(verse);

            string userInput = "";
             while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.CreateReference());
            Console.WriteLine(scripture.Display());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }

        }
        else if(newEntry == 2){
            verse = "9 For behold, to one is given by the Spirit of God, that he may teach the word of wisdom; And to another, that he may teach the word of knowledge by the same Spirit;"; 
            Reference reference = new Reference("Moroni", 10, 9, 10);
            string referenceTitle = reference.CreateReference();
            Scripture scripture = new Scripture(verse);

            string userInput = "";
             while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.CreateReference());
            Console.WriteLine(scripture.Display());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }

        }
        else if(newEntry == 3){
            verse = "Nevertheless I tell you the truth; It is expedient for you that I go away: for if I go not away, the Comforter will not come unto you; but if I depart, I will send him unto you."; 
            Reference reference = new Reference("John", 16, 7);
            string referenceTitle = reference.CreateReference();
            Scripture scripture = new Scripture(verse);

            string userInput = "";
             while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.CreateReference());
            Console.WriteLine(scripture.Display());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }

        }
        else if(newEntry == 4){
            verse = "And moreover, I say unto you, that there shall be no other name given nor any other way nor means whereby salvation can come unto the children of men, only in and through the name of Christ, the Lord Omnipotent."; 
            Reference reference = new Reference("Mosiah", 3, 17);
            string referenceTitle = reference.CreateReference();
            Scripture scripture = new Scripture(verse);

            string userInput = "";
             while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.CreateReference());
            Console.WriteLine(scripture.Display());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            
        }

        }
        else if(newEntry == 5){
            verse = "4 Hear, O Israel: The Lord our God is one Lord: And thou shalt love the Lord thy God with all thine heart, and with all thy soul, and with all thy might."; 
            Reference reference = new Reference("Deuteronomy", 6, 4, 5);
            Scripture scripture = new Scripture(verse);
            bool finished = false;
            string userInput = "";
             while (userInput.ToUpper() != "QUIT" + finished == false ) 
        {
            Console.Clear();
            Console.WriteLine(reference.CreateReference());
            Console.WriteLine(scripture.Display());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            
            

        }
        
    }
}
}