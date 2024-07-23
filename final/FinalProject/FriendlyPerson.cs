class FriendlyPerson : Person
{
    public FriendlyPerson(string name) : base(name) { }

    protected override void InitializeResponses()
    {
        responses = new Dictionary<string, string[]>
        {
            {"hello", new[] {$"Hi there! I'm {name}!", $"Hello, friend! {name} here!", $"Greetings! It's {name}!"}},
            {"how are you", new[] {"I'm doing fantastic, thanks!", "Great! How about you?", "Wonderful! Thanks for asking!"}},
            {"goodbye", new[] {"Goodbye, take care!", "See you later, friend!", "Have a great day!"}},
            {"default", new[] {"That's interesting! Tell me more!", "I'd love to hear your thoughts on that!", "Fascinating! What else?"}}
        };
    }
}