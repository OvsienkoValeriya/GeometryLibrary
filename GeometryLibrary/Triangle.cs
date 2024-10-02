
namespace GeometryLibrary;

public class Triangle(double a, double b, double c) : IShape
{
    public double CalculateFigureArea()
    {
        var halfPerimeter = CalculateFigurePerimeter() / 2;
        var area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return area;
    }

    private double CalculateFigurePerimeter()
    {
        return a + b + c;
    }

    public bool IsRightTriangle(double tolerance = Defaults.Tolerance)
    {
        var sidesArr = new[] { a, b, c };
        Array.Sort(sidesArr);

        var hypotenuse = sidesArr[2];
        var opposite = sidesArr[0];
        var adjacent = sidesArr[1];

        return Math.Abs(Math.Pow(hypotenuse,2) - (Math.Pow(opposite,2) + Math.Pow(adjacent, 2))) < tolerance;
    }
}