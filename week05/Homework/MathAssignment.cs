using System;

class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;


    public MathAssignment(string StudentName, string Topic, string textbookSection, string problems) : base(StudentName, Topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

     public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}