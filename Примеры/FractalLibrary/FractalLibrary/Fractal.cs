namespace FractalLibrary;

public class Fractal
{
    /// <summary>
    /// Фрактал
    /// </summary>
    /// <param name="centerX">Координата X центра комплексной области</param>
    /// <param name="centerY">Координата Y центра комплексной области</param>
    /// <param name="width">Ширина комплексной области</param>
    /// <param name="rows">Количество строк сетки</param>
    /// <param name="columns">Количество столбцов сетки</param>
    public Fractal(double centerX, double centerY, double width, int rows, int columns)
    {
        CenterX = centerX;
        CenterY = centerY;
        Width = width;
        Rows = rows;
        Columns = columns;
    }

    public int IterationsLimit { get; set; } = 100;

    public double Tolerance { get; set; } = 1e-3;

    // Координата X центра комплексной области
    public double CenterX { get; }

    // Координата Y центра комплексной области
    public double CenterY { get; }

    // Ширина комплексной области
    public double Width { get; }

    // Высота комплексной области, рассчитывается автоматически пропорционально ширине
    public double Height => Width * Rows / Columns;

    // Количество строк сетки
    public int Rows { get; }

    // Количество столбцов сетки
    public int Columns { get; }

    /// <summary>
    /// Рассчитать значения (количество итераций) в каждой ячейке
    /// </summary>
    /// <returns></returns>
    public FractalRootsField Calculate()
    {
        var field = new RootInField[Rows, Columns];

        var roots = new List<(Complex Root, int Id)>
        {
            (new Complex(1, 0), 0),
            (new Complex(-0.5,Math.Sqrt(3)/2), 1),
            (new Complex(-0.5,-Math.Sqrt(3)/2), 2)
        };

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                var x = CenterX + Width * j / (Columns - 1) - Width / 2;
                var y = CenterY + Height * i / (Rows - 1) - Height / 2;

                var z = new Complex(x, y);

                var founded = FindRoot(z, Tolerance, IterationsLimit);

                var (root, id) = roots.MinBy(r => (r.Root - founded.Root).Magnitude);

                field[i, j] = new RootInField(founded, (root - founded.Root).Magnitude < Tolerance ? id : -1);
            }
        }

        return new FractalRootsField(field, roots.Select(r => r.Root).ToArray());
    }

    public RootResult FindRoot(Complex z0, double tolerance, int iterationsLimit)
    {
        var z = new Complex(z0.Re, z0.Im);

        var iterations = 0;

        while (iterations <= IterationsLimit)
        {
            var delta = f(z) / df(z);

            z -= delta;

            if (delta.Magnitude < tolerance)
                break;

            iterations++;
        }

        return new RootResult(z, iterations);
    }

    private Complex f(Complex z) => z.Pow(3) - 1;

    private Complex df(Complex z) => 3 * z.Pow(2);
}

public readonly record struct RootResult(Complex Root, int Iterations);

public readonly record struct RootInField(RootResult RootResult, int RootId);

public readonly record struct FractalRootsField(RootInField[,] Field, Complex[] FoundRoots);
