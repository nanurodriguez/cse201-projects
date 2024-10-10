using System;

public class Video
{
    public string _title;
    public string _author;
    public int _videoLength; //in seconds

    public List<Comment> _comments = new List<Comment>();
    public void AddComment(string comment)
    {
        //Stores a list of comments and adds it to the video display all
    }

    public int CountComments()
    {
        return 0; //returning number of comments from the comment section
    }


    public string DisplayVideo()
    {
        string videoDescription = $"{_title} - {_author} - {_videoLength} seconds";
        return videoDescription;
        //displays the video title, author name, video lenght in seconds.
    }


}

