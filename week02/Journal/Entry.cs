using System;

public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _location;



    public Entry(string Date, string PromptText, string EntryText, string Mood, string Location){
        _date = Date;
        _promptText = PromptText;
        _entryText = EntryText;
        _mood = Mood;
        _location = Location;
    }


    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"How do you feel?: {_mood}");
        Console.WriteLine($"Whats your Location?: {_location}");
    }
}