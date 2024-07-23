class FamilyMember : Person
{
    public FamilyMember(string name) : base(name) { }

    protected override void InitializeResponses()
    {
        responses = new Dictionary<string, string[]>
        {
            {"hello", new[] {$"Good day. I am {name}.", $"Greetings. {name} at your service.", $"Hello. {name} speaking."}},
            {"how are you", new[] {"I am well, thank you.", "I am fine. How may I assist you?", "I am doing well. And you?"}},
            {"goodbye", new[] {"Goodbye. Have a pleasant day.", "Farewell.", "Until next time."}},
            {"default", new[] {"I see. Please elaborate.", "Interesting. Could you provide more details?", "I understand. What are your thoughts on this matter?"}}
        };
    }
}