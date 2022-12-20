namespace SquareCalculator;

public class Triangle: IFigure
{
    public double A { get; }
    public double B { get;  }
    public double C { get;  }
    
    public bool IsRight { get;  }

    internal Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
        IsRight = Math.Round(a * a + b * b,Constants.Accuracy) == Math.Round(c * c,Constants.Accuracy)
                  || Math.Round(a * a + c * c,Constants.Accuracy) == Math.Round(b * b,Constants.Accuracy)
                  || Math.Round(c * c + b * b,Constants.Accuracy) == Math.Round(a * a,Constants.Accuracy);
    } 
    
    public bool IsValid()
    {
        if (A+B > C && A+C > B && C+B > A)
        {
            return true;
        }

        return false;
    }

    public double GetSquare()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
    
}