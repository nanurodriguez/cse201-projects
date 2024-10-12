using System;
using System.Security.Cryptography.X509Certificates;


public class Comment
{

    public string _commentUser;
    public string _comments;

    public Comment(string user, string comments)
    {
        _commentUser = user;
        _comments = comments;

        /*foreach (var item in _commentAndUser)
        {
            string[] userAndComment = item.Split(" - ");
            Comment_commentUser.Add[]

        }
        */

    }

    public string DisplayAll()
    {
        string commenting = $"{_commentUser} - {_comments}";
        return commenting;


    }

}