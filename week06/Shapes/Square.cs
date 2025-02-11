using System;

class Square : Shape{
    private double side;


    public Square(string color, double Side ) : base(color){
        side = Side;
    }


    public override double GetArea()
    {
        return side * side;
    }
}

