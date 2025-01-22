using System;

public class Fraction{
    private int _topNumber;
    private int _bottomNumber;


    public Fraction()
{
    _topNumber = 1;
    _bottomNumber = 1;
}

   public Fraction(int TopNumber)
{
    _topNumber = TopNumber;
    _bottomNumber = 1;
}

    public Fraction(int TopNumber, int BottomNumber)
{
    _topNumber = TopNumber;
    _bottomNumber = BottomNumber;
}


public void setTopNumber(int _topNumber)
{
    _topNumber = 3;
}

public void setBottomNumber(int _bottomNumber)
{
    _bottomNumber = 4;
}

public int getTopNumber() {
        return _topNumber;
    }

    
    public int getBottomNumber() {
        return _bottomNumber;
    }

    public string GetFractionString ()
    {
        string Text = $"{_topNumber}/{_bottomNumber}";
        return Text;

    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / _bottomNumber;
    }
}    