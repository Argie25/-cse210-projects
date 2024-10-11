public class Video 
{
    private string _author;
    private string _title;
    private int _seconds;
    public List<Comment> _comments;

    public Video (string author, string title, int seconds)
    {
        _author = author;
        _title = title;
        _seconds = seconds;
        _comments = new List<Comment>();
    }

    public void AddComment(string person, string comment)
    {
        _comments.Add(new Comment(person, comment));
    }

    
    public int CountComments()
    {
        return _comments.Count ;
    }

    public void DisplayAll()
    {
        System.Console.WriteLine($"Author: {_author}\nTitile: {_title}\nVideo Second: {_seconds}");
        System.Console.WriteLine($"Number of Comments: {CountComments()}");

        foreach (Comment comment in _comments)
        {
            System.Console.WriteLine(comment.GetComment());
        }

    }
    
}