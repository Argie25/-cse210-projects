public class Comment
{
    private string _person;
    private string _comment;

    public Comment(string person, string comment)
    {
        _person = person;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_person}: {_comment}";
    }

}