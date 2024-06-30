using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Scripture{

    
private List<string> _words = new List<string>();

    

    public Scripture(string verse){
        List<string> wordsList = new List<string>(verse.Split(" "));
        _words = wordsList;


    }

    public string Display()
    {
         return string.Join(" ",_words);
    }
    
    public void HideWords()
    {
      Random r = new Random();
        
        
        
            int count = 0;
            while(count < 3){
            int randomNumber = r.Next(_words.Count);
            Word word = new Word(_words[randomNumber]);
            
            
            if (word.IsHidden(_words[randomNumber]) != true)
            {
                string change = word.Hide();
                _words[randomNumber] = change;
               
            }
            count = count + 1;
            }
            
        
    }
    public bool IsCompletelyHidden()
    {
        bool condition = false;
        foreach(string word in _words)
        {
            
            if(word == "___"){
                 condition = true;
            }
            else{
                condition = false;
            }
            
        }
        return condition;
    }


}