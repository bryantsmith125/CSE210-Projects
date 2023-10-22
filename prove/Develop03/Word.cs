using System;

class Word
{
    private string word;
    private bool isHidden;

    public void SetIsHidden(bool _isHidden)
    {
        isHidden = _isHidden;
    }

    public bool GetIsHidden()
    {
      return isHidden;  
    }
    


    public string GetWord()
    {
        return word;
    }

    public Word(string _word)
    {
        word = _word;
    }
}