using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Uche" , "Iron Mask");

        Console.WriteLine($"{assignment.GetSummary()}");

        
        Assignment assignment1 = new Assignment("Uchenna Onuorah", "Iron Man");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Belenu Rita", "Encapsulation", "14.0", "7-14");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("John Obi", "Afirca Culture", "Developing Continent");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
    
}