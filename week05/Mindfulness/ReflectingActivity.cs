using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) 
        : base("Reflecting", "This activity helps you to reflect on various prompts and questions.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you felt truly at peace.",
            "Reflect on a recent accomplishment.",
            "Consider a challenge you overcame.",
            "Recall a moment when you helped someone."
        };

        _usedPrompts = new List<string>();

        _questions = new List<string> 
        { 
            "What did you learn?", 
            "How did you feel?", 
            "What was your experience like?", 
            "How did it impact you?" 
        };    
    }

    protected override void PerformActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Consider the following prompt:\n---{prompt}---");
        DisplaySpinner(3);
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        DisplaySpinner(3);
        string question = GetRandomQuestion();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write($"You may begin in  ");
        ShowCountDown(5);
        Console.WriteLine(question);
        DisplaySpinner(3);
        Console.ReadLine();
    }

    private string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear(); 
        }

        var availablePrompts = _prompts.Except(_usedPrompts).ToList();
        Random random = new Random();
        int index = random.Next(availablePrompts.Count);
        string selectedPrompt = availablePrompts[index];
        _usedPrompts.Add(selectedPrompt);
        return selectedPrompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public override void Run()
    {
        base.Run();
    }

    public void DisplayQuestion(){
        DisplayQuestion();
    }
}

    

