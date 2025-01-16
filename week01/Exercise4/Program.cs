using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 1;
        int sum = 0;

        while (true)
        {
            Console.Write(" Enter number:     ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbers.Add(number);
        }    
        
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum += num;
            
        }

        double average = (double) sum / numbers.Count;
        int max = numbers.Max();
        
    Console.WriteLine($" The sum is: {sum} ");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {max}");
        
    }
}