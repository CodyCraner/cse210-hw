using System.Runtime.InteropServices;

class Reference{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
    }
     public Reference(string book, int chapter, int verse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _secondVerse = secondVerse;
    }
    public string CreateReference()
    {
         if (_secondVerse == 0)
        {
            return ($"{_book} {_chapter}:{_firstVerse} ");
        }
        else
        {
            return ($"{_book} {_chapter}:{_firstVerse}-{_secondVerse}");
        }

    }


}