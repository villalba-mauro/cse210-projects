// Circle.cs
public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Sobrescribimos el método GetArea para calcular el área de un círculo
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
