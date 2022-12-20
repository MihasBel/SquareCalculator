namespace SquareCalculator;

public static class FigureFabric
{
    public static IFigure CreateFigure(double radius)
    {
        return new Circle(radius);
    }

    public static IFigure CreateFigure(List<double> sides)
    {
        IFigure figure;
        switch (sides.Count)
        {
            case 0:
                throw new Exception("not a single side is set");
            case 1:
                figure = CreateFigure(sides[0]);
                break;
            case 2:
                throw new NotImplementedException();
            case 3:
                figure = new Triangle(sides[0], sides[1], sides[2]);
                break;
            default:
                throw new NotImplementedException();
        }
        figure.IsValid();
        return figure;
    }
}