

public class PictureBook : Book // Picture Book is a BOOK
{

    private string _illustrator = "";

    public PictureBook(string author, string title, string illustrator) : base(author, title)
    {
        _illustrator = illustrator;
    }
    public string GetIllustrator()
    {
        return _illustrator;
    }
    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetIllustratorInfo()
    {

        return $"Illustrator: {_title} by {_author} illustrated by {_illustrator}";
    }




}