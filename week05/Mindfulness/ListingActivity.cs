using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _usedPrompts;

    public ListingActivity(int duration) 
        : base("Listing", "This activity helps you to list items or tasks.", duration)
    {
        _prompts = new List<string>
        {
            "List as many positive qualities about yourself as you can.",
            "List things you are grateful for today.",
            "List activities that make you feel relaxed.",
            "List people who have positively influenced your life.",
            "List your favorite books.",
            "List your goals for today."
        };

        _usedPrompts = new List<string>();
    }

    protected override void PerformActivity()
    {
        string topic = GetUniqueTopic();
        Console.WriteLine("List as many responses you can to the following prompts");
        Console.WriteLine(topic);
        DisplaySpinner(5);
        Console.WriteLine("You may begin in   ");
        ShowCountDown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> userList = GetListFromUser(endTime);
    }

    private string GetUniqueTopic()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        var availableTopics = _prompts.Except(_usedPrompts).ToList();
        Random random = new Random();
        int index = random.Next(availableTopics.Count);
        string selectedTopic = availableTopics[index];
        _usedPrompts.Add(selectedTopic);
        return selectedTopic;
    }

    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> userList = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            userList.Add(item);
        }
        return userList;
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("Start listing...");

    }
}