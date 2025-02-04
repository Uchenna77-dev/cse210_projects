using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {  while (true)
        {
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Select a choice from the Menu:");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }


            switch (choice)
            {
                case "1":
                    StartActivity(new BreathingActivity(10));
                    break;
                case "2":
                    StartActivity(new ReflectingActivity(5));
                    break;
                case "3":
                    StartActivity(new ListingActivity(10));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("All activities have been completed. Thank you for participating!");
        }
    }

    static void StartActivity(Activity activity){
        activity.Start();
    }
    
}