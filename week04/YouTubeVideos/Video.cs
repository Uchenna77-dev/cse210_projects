using System;
using System.Collections.Generic;

class Video {
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> Comments;


    public Video(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
        Comments = new List<Comment>();
    }

    public void AddComment (Comment comment) {
        Comments.Add(comment);
    }

     public int GetCommentCount()
    {
        return Comments.Count;
    }
    public void DisplayComments () {
        foreach (var comment in Comments) {
            Console.WriteLine($"  - {comment}");
        }
    }

    public override string ToString()
    {
        int minutes = _length / 60;
        int seconds = _length % 60;
        return $"Title: {_title}\nAuthor: {_author}\nLength: {minutes}m {seconds}s\nNumber of Comments: {GetCommentCount()}\n";
    } 
    
}