using System;

class Circle : Shape{
    private double radius;
    


    public Circle(string color, double Radius) : base(color){
        radius = Radius;
    }


    public override double GetArea()
    {
        return radius * radius * Math.PI;
    }
}