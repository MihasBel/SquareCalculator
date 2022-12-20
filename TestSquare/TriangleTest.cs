namespace TestSquare;

public class TriangleTest
{
    [Test]
    public void InvalidTriangle()
    {
        var sides = new List<double> { 2, 3, 100 };
        Assert.Throws<Exception>(()=>
        {
            var triangle = FigureFabric.CreateFigure(sides);
            
        });
    }

    [Test]
    public void CorrectTriangle()
    {
        var sides = new List<double> { 2, 3, Math.Sqrt(13) };
        double expectedSqr = 3;
        var triangle = FigureFabric.CreateFigure(sides);
        Assert.That(expectedSqr, Is.EqualTo(triangle.GetSquare()));
    }

    [Test]
    public void RightTriangle()
    {
        var sides = new List<double> { 2, 3, Math.Sqrt(13) };
        var triangle = (Triangle)FigureFabric.CreateFigure(sides);
        Assert.IsTrue(triangle.IsRight);
    }
}