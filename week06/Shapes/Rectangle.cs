using System;

class Rectangle : Shape{
    private double lenght;
    private double width;


    public Rectangle(string color, double Lenght, double Width ) : base(color){
        lenght = Lenght;
        width = Width;
    }


    public override double GetArea()
    {
        return lenght * width;
    }
}
