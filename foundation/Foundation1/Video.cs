/*public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<string> _listOfComment;

    public Video (string title, string author, int leght)
    {
        _title = title;
        _author = author;
        _lenght = leght;
        _listOfComment = new List<Comment>();
    }




}

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
*/
using System;
using System.Collections.Generic;


public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // en segundos
    private List<Comment> comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }

    // Método para agregar un comentario
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Método para obtener la cantidad de comentarios
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Método para mostrar todos los comentarios
    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
    }
}