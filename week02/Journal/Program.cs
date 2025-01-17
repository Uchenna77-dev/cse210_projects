using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to my Journal Program.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string PromptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {PromptText}");
                    Console.Write("Your response: ");
                    string EntryText = Console.ReadLine();
                    Console.Write("How do you feel: ");
                    string Mood = Console.ReadLine();
                    Console.Write("Whats your location: ");
                    string Location = Console.ReadLine();
                    string Date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry _entryText = new Entry(Date, PromptText, EntryText, Mood, Location);
                    journal.AddEntry(_entryText);
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter the filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved.");
                    break;

                case "4":
                    Console.Write("Enter the filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    
    }
}