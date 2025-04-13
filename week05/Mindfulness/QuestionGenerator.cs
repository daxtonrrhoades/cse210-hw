using System;

public class QuestionGenerator
{
    public List<string> _questions;

    public QuestionGenerator()
    {
        _questions = new List<string>
        {
            // write your questions here
        };
    }

    public string GetrandomQuestion()
    {
        Random rand = new Random();
        int i = rand.Next(_questions.Count);
        return _questions[i];
    }
}