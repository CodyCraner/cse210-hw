class ConversationSimulator
{
    private List<Person> participants;

    public ConversationSimulator()
    {
        participants = new List<Person>
        {
            new FriendlyPerson("Alice"),
            new FamilyMember("Bob")
        };
    }

    public void StartConversation()
    {
        Console.WriteLine("Conversation started. Type 'goodbye' to end the conversation.");

        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "goodbye")
            {
                foreach (var participant in participants)
                {
                    Console.WriteLine($"{participant.GetType().Name}: {participant.GetResponse(userInput)}");
                }
                break;
            }

            foreach (var participant in participants)
            {
                Console.WriteLine($"{participant.GetType().Name}: {participant.GetResponse(userInput)}");
            }
        }
    }
}
