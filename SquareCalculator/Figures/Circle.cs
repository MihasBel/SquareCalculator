namespace SquareCalculator;

public class Circle: IFigure
{
    public double Radius { get; set; }

    internal Circle(double r)
    {
        Radius = r;
    }
    public bool IsValid()
    {
        return Radius >0;
    }

    public double GetSquare()
    {
        return Math.PI * Radius * Radius;
    }
}