using System.ComponentModel.DataAnnotations;

class entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public entry(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

    public entry()
    {
        

    }

    public override string ToString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
    
}




