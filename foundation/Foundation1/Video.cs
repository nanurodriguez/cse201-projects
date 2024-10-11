using System;
using System.Diagnostics;

public class Video
{
    public string _title;
    public string _author;
    public int _videoLength; //in seconds

    public Comment _comment;

    public string _text;

    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int videoLenght, Comment comment)
    {
        //Stores a list of comments and adds it to the video display all

        _comment = comment;
        _title = title;
        _author = author;
        _videoLength = videoLenght;

        /*string[] words = _text.Split(' ');

        foreach (var item in words)
        {
            _comments.Add(new Comment(item, item));// creating list of objects
        }
        */
    }
    /*
   public int CountComments()
   {

       string comment = "";
       int count = comment.Split('/').Length - 1;
       return count; //returning number of comments from the comment section

   }
    */


    public string DisplayAll()
    {
        string _videoText = "";
        foreach (Comment comment in _comments)
        {
            string getText = comment.DisplayAll();
            _videoText = _videoText + getText;
        }
        string video1 = $"{_title} - {_author} - {_videoLength} seconds";
        //{_comments.DisplayAll()}";
        return video1;
        //displays the video title, author name, video lenght in seconds.
    }


}

