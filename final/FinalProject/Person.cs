abstract class Person
{
    protected string name;
    protected Dictionary<string, string[]> responses;
    protected Random random;

    public Person(string name)
    {
        this.name = name;
        random = new Random();
        InitializeResponses();
    }

    protected abstract void InitializeResponses();

    public string GetResponse(string input)
    {
        input = input.ToLower().Trim();

        if (responses.ContainsKey(input))
        {
            string[] possibleResponses = responses[input];
            return possibleResponses[random.Next(possibleResponses.Length)];
        }
        else
        {
            string[] defaultResponses = responses["default"];
            return defaultResponses[random.Next(defaultResponses.Length)];
        }
    }
}
