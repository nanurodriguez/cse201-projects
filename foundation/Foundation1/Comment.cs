using System;


public class Comment
{
    public string _commentUser;

    public string _comments;

    public Comment(string user, string comment)
    {
        _commentUser = user;
        _comments = comment;
    }

    public string DisplayAll()
    {
        string commenting = $@"Comments:
                            -{_commentUser}- {_comments}";
        return commenting;


    }

}