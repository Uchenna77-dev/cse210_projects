using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 

        string userName = PromptUserName(); 
        int userNumber = PromptUserNumber(); 
        int squaredNumber = SquareNumber(userNumber); 

        DisplayResult(userName, squaredNumber); 
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int value)
    {
        return value * value;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"Hello {userName}, the square of your number is {square}. ");
    }

}