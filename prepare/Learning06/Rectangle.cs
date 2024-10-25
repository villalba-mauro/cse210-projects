// Rectangle.cs
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Sobrescribimos el método GetArea para calcular el área de un rectángulo
    public override double GetArea()
    {
        return _length * _width;
    }
}
