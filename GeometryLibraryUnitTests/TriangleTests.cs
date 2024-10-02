using GeometryLibrary;

namespace GeometryLibraryUnitTests;

public class TriangleTests
{

    [Test]
    public void Triangle_CalculateArea_ReturnsCorrect()
    {
        var triangle = new Triangle(3,4,5);
        var area = triangle.CalculateFigureArea();
        Assert.That(area, Is.EqualTo(6).Within(Defaults.Tolerance));
    }
    
    [Test]
    public void Triangle_IsRight_ReturnsCorrect()
    {
        var triangle = new Triangle(15,20,25);
        var isRight = triangle.IsRightTriangle();
        Assert.That(isRight, Is.EqualTo(true));
    }
    
}