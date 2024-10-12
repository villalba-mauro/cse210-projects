/*using System.Globalization;

public class Comment
{
    private string _personName;
    private string _personComment;
    private List <string> _ramdonComment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _personComment = comment;
        
        List<Comment> comments = new List<Comment>();
    }
    
    public void DisplayComment()
    {
        Console.WriteLine($" {_personName} - {_personComment}");
    }

        public string GetRandomComment()
    {

        _ramdonComment = [
        "I liked your video!",
        "It was so helpful man.",
        "You have an incredible energy.",
        "Your work is trully impressive.",
        "Your attention to detail is remarkable.",
        "You are a great teamplayer.",
        "You need to work on your communication skills.",
        "Don't be afraid to share your ideas.",
        "Your overall performance has been excelent.",
        "I really like your work on this project.",
        "I think you could have spend more time on the final review of the document."];


        Random random = new Random();

        int index = random.Next(_ramdonComment.Count);

        string comment = _ramdonComment[index];

        return comment;
    }
} */

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
