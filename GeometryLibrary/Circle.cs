namespace GeometryLibrary;

public class Circle(double radius) : IShape
{
    public double CalculateFigureArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}