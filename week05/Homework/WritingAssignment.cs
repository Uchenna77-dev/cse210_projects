using System;

class WritingAssignment : Assignment
{
    private string _title;

    
    public WritingAssignment(string StudentName, string Topic, string title)
        : base(StudentName, Topic)
    {
        
        _title = title;
    }

    public string GetWritingInformation()
    {
       
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
    }