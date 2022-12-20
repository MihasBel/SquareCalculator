namespace TestSquare;

public class CircleTest
{
    [Test]
    public void CorrectCircle()
    {
        double radius = 3;
        double expectedSqr = 28.27433388;
        var circle = FigureFabric.CreateFigure(radius);
        Assert.That(expectedSqr, Is.EqualTo(circle.GetSquare()));
    }
}