using System;
// I added a list of scripture from which the program picks one at random.
class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding"),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten son that who so ever believe in him should not perish but have eternal life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me"),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want"),
            new Scripture(new Reference("Matthew", 7, 7, 8), "Ask, and you will receive; seek, and you will find; knock, and the door will be opened to you. 8For everyone who asks will receive, and anyone who seeks will find, and the door will be opened to those who knock."),
        };

        var random = new Random();

        while (true)
        {
            Scripture currentScripture = scriptures[random.Next(scriptures.Count)];

            currentScripture.Display();

            
            if (currentScripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Memorization complete for this scripture.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            currentScripture.HideWords(2);
        }
    }
}
