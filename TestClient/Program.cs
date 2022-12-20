using SquareCalculator;

IFigure figure = FigureFabric.CreateFigure(3);

Console.WriteLine(figure.GetSquare());

figure = FigureFabric.CreateFigure(new List<double> { 2, 3, Math.Sqrt(13) });

Console.WriteLine(figure.GetSquare());
Triangle tr = (Triangle)figure;

Console.WriteLine(tr.IsRight);


