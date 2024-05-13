
public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        string[] scriptureWords = scripture.Split();

        foreach (string _word in scriptureWords)
        {
            Word w = new Word(_word);
            _words.Add(w);
        }
    }

    public void DisplayScripture()
    {
        foreach (Word _word in _words)
        {
            _word.DisplayWord();
        }
    }

    public void HideWords()
    {
        Random rnd = new Random();
        var shuffledList = _words.OrderBy(a => rnd.Next()).ToList();
        int counter = 0;

        foreach (Word _word in shuffledList)
        {
            if (counter == 3)
            {
                break;
            }
            else if (_word.IsHidden() == true)
            {
                continue;
            }
            else
            {
                _word.Hide();
                counter++;
            }
        }
    }

    public void ShowWords()
    {
        Random rnd = new Random();
        var shuffledList = _words.OrderBy(a => rnd.Next()).ToList();
        int counter = 0;

        foreach (Word _word in shuffledList)
        {
            if (counter == 3)
            {
                break;
            }
            else if (_word.IsHidden() == false)
            {
                continue;
            }
            else
            {
                _word.Show();
                counter++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool option = false;
        foreach (Word _word in _words)
        {
            if (_word.IsHidden() == false)
            {
                option = false;
                break;
            }
            else
            {
                option = true;
            }
        }
        return option;
    }
}

// public class Scripture
// {
//     private Reference _reference;

// private List<Word> _words = new List<Word>();

// public Scripture(Reference reference, string text)
// {
//     _reference = reference;

//     string[] words = text.Split(" ");
//     // con split se divide cada palabra cuando dejar un "espacio"
//     foreach (string item in words)
//     {
//         Word newWord = new Word(item);
//         _words.Add(newWord);
//     }
// }

// public void HideRandomWords(int numberToHide)
// {
//     Console.WriteLine("hiding ransomwords");
//     Console.ReadLine();
//     List<int> randomNumbers = [0, 1, 2];
//     Random random = new Random();

//     for (int i = 0; i < numberToHide; i++)
//     {
//         // randomNumbers[i] = random.Next(1, 6);
//         randomNumbers.Add(random.Next(0, _words.Count() - 1));
//     }

//     foreach (int i in randomNumbers)
//     {
//         _words[i].Hide();
//     }
// }

// public string GetDisplayText()
// {
//     string referenceText = _reference.GetDisplayText();
//     // string scriptureContent = "";
//     List<string> scriptureContent = new List<string>();
//     foreach (Word word in _words)
//     {
//         scriptureContent.Add(word.GetDisplayText());
//     }
//     string scriptureText = string.Join(" ", scriptureContent);
//     return $"{referenceText} {scriptureText}";
// }

// public bool IsCompletelyHidden()
// {
//     foreach (Word word in _words)
//     {
//         if (word.IsHidden() == true)
//         {
//             return false;
//         }
//     }

//     return false;
// }


// }
