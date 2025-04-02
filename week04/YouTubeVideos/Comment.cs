using System;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetCommentString()
    {
        string commentString = $"{_name}: {_comment}";
        return commentString;
    }
}