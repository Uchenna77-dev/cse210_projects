using System;

public class Word
{
    private string text;
    private bool hidden;

    public Word(string Text)
    {
        text = Text;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}
