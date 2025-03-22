using System;
using System.Text;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var token in text.Split(' '))
        {
            _words.Add(new Word(token));
        }
    }

    public bool IsCompletelyHidden()
    {
        int notHiddenCount = _words.Count(word => !word.IsHidden());
        return notHiddenCount == 0;
    }

    public string GetDisplayText()
    {
        var referenceText = _reference.GetDisplayText();
        var scriptureText = new StringBuilder();
        foreach (var word in _words)
        {
            if (word.IsHidden())
            {
                string hiddenText = new string('_', word.GetDisplayText().Length);
                scriptureText.Append(hiddenText);
                scriptureText.Append(" ");
            }
            else
            {
                scriptureText.Append(word.GetDisplayText());
                scriptureText.Append(' ');
            }
        }
        return referenceText + " " + scriptureText.ToString();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden())
                                .OrderBy(_ => random.Next())
                                .Take(numberToHide);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }
}