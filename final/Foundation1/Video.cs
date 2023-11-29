using System;

public class Video
{
    public string _title;
    public string _author;
    public int _videoLength; 
    public int commentCount;
    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLength} seconds\n");
        commentCount = GetNumberOfComments();
        Console.WriteLine($"Viewer Comments({commentCount}):");
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();

        }
        Console.WriteLine("\n****************************\n");
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


}