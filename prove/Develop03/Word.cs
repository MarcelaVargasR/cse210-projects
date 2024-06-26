public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void DisplayWord()
    {
        if (_isHidden == true)
        {
            for (int index = 1; index <= _word.Length; index++)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
}

// public class Word
// {
//     private string _text;

// private bool _isHidden;

// public Word(string text)
// {
//     _text = text;
//     _isHidden = false;
// }

// public void Hide()
// {
//     _isHidden = true;
// }

// public void Show()
// {
//     _isHidden = false;
// }

// public bool IsHidden()
// {
//     return _isHidden;
// }

// public string GetDisplayText()
// {
//     if (_isHidden == true)
//     {
//         return new string('_', _text.Length);
//     }

//     return _text;

// }
// }
