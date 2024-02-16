using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public void AddComment(string commenterName, string commentText)
    {
        Comments.Add(new Comment { CommenterName = commenterName, CommentText = commentText });
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"Comment by {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}

public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
}
