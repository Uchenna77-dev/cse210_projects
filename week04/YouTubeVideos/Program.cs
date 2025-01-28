using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

          Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        var video1 = new Video("Learning C# Basics", "Duane Richards", 700);
        var video2 = new Video("Advanced C# Techniques", "Richards Drake", 540);
        var video3 = new Video("Python Over R", "Alice Johnson", 1000);

        
        video1.AddComment(new Comment("Uchenna", "Nice and Exciting!"));
        video1.AddComment(new Comment("Rita", "Thanks for explaining so clearly."));
        video1.AddComment(new Comment("john", "Well detailed, Intresting!!!"));

        video2.AddComment(new Comment("Samuel", "This is for Beginners. Smiles!!!"));
        video2.AddComment(new Comment("James", "I have learned a lot, this is an advanced stuff."));
        video2.AddComment(new Comment("Robert", "I will always prefer Pyhton!"));

        video3.AddComment(new Comment("Joy", "Best Explaination ever!."));
        video3.AddComment(new Comment("Samson", "I am completely lost, this is too advanced."));
        video3.AddComment(new Comment("Jamilu", "I am not yet convinced."));

        var videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine(new string('-', 40));
        }
    }
  
    
}