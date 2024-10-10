using System;


public class Comment
{
    public string _commentUser;

    public string _comments;

    public void AddComment(string comment)
    {

        _comments = comment;

        string[] words = _comments.Split(' '); //split long string into list separated by ' ' (space)

        foreach (var item in words)
        {

            _comments.Add(new Video());
        }
    }

    public string DisplayComments()
    {
        Console.Write($"Comments:");
        string commenting = $@"Comments:
                            -{_commentUser}- {_comments}";
        return commenting;


    }

}