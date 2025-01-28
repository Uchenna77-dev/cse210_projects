using System;

class Comment {
    public string _commentername;
    public string _commenttext;


    public Comment(string CommenterName, string CommentText) {
        _commentername = CommenterName;
        _commenttext = CommentText;
    }

    public override string ToString()
    {
        return $"{_commentername}: {_commenttext}";
    }
}    