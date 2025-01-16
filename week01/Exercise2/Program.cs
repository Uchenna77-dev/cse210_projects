using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine(" What is your grade percentage?");
        int value = int.Parse(Console.ReadLine());

        string letter = "";

        if (value >= 90)
        {
            letter = "A";
            
        }
        
        else if (value >= 80)
        {
            letter = "B";
            
        }

        else if (value >= 70)
        {
            letter = "C";
            
        }

        else if (value >=60)
        {
            letter = "D";
               
        }

        else
        {
            letter = "F";
            
        }

        if (value >= 70 )
        {
            Console.WriteLine(" Congratulations, You Passed!!!");
            Console.WriteLine($" You scored {value}, your grade is {letter}.");
        }
        
        else
        {
            Console.WriteLine(" You can do better, kindly retake the course you scored below 70!!! ");
            Console.WriteLine($" You scored {value}, your grade is {letter}.");
        }

        

    }
}