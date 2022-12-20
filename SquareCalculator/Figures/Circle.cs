namespace SquareCalculator;

public class Circle: IFigure
{
    public double Radius { get; set; }

    internal Circle(double r)
    {
        Radius = r;
    }
    public void IsValid()
    {
        if (Radius>0)
        {
            return;
        }
        throw new Exception("Invalid argument to create circle");
    }

    public double GetSquare()
    {
        return Math.Round(Math.PI * Radius * Radius,Constants.Accuracy);
    }
}