using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference Reference, string text)
    {
        reference = Reference;
        words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{reference}");
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideWords(int count)
    {
        var random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < count)
        {
            int index = random.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
