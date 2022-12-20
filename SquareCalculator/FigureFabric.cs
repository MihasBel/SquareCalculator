namespace SquareCalculator;

public static class FigureFabric
{
    public static IFigure CreateFigure(double radius)
    {
        var circle = new Circle(radius);
        if (circle.IsValid())
        {
            return circle;
        }
        throw new Exception("Invalid argument to create circle");
    }

    public static IFigure CreateFigure(List<double> sides)
    {
        switch (sides.Count)
        {
            case 0:
                throw new Exception("not a single side is set");
            case 1:
                return CreateFigure(sides[0]);
            case 2:
                throw new NotImplementedException();
            case 3:
                var triangle = new Triangle(sides[0], sides[1], sides[2]);
                if (triangle.IsValid())
                {
                    return triangle;
                }
                throw new Exception("Invalid arguments to create triangle");
            default:
                throw new NotImplementedException();
        }
    }
}