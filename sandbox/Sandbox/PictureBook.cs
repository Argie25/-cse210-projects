public class PictureBook : Book
{
    private string _illustrator;

    public void SetIllustrator(string illistrator)
    {
        _illustrator = illistrator;
    }

    public string GetIllusttrator()
    {
        return _illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{_title} by {_author} illustraded by {_illustrator}";
    }
}