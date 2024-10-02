using GeometryLibrary;

namespace GeometryLibraryUnitTests;

public class CircleTests
{
    [Test]
    public void Circle_CalculateArea_ReturnsCorrect()
    {
        var circe = new Circle(5);
        Assert.That(circe.CalculateFigureArea(), Is.EqualTo(Math.PI * 25).Within(Defaults.Tolerance));
    }
}