namespace IntegralCalculatorApp;

public record IterationSolvedEvemtArgs(int Iteration, double Sum);
public delegate void IterationSolved(object sender, IterationSolvedEvemtArgs args);
public class GaussIntegralCalculator
{
    // Точки и веса для метода Гаусса-2
    private static readonly double[] GaussPoints = { -1.0 / Math.Sqrt(3), 1.0 / Math.Sqrt(3) };
    private static readonly double[] GaussWeights = { 1.0, 1.0 };

    // Функция, которую интегрируем (x^2)

    public event IterationSolved? IterationSolved;

    public double CalculateIntegral(Func<double, double> f, double a, double b, int segments)
    {
        if (segments <= 0)
            throw new ArgumentException("Количество сегментов должно быть положительным");

        double segmentWidth = (b - a) / segments;
        double sum = 0.0;

        for (int i = 0; i < segments; i++)
        {
            double segmentA = a + i * segmentWidth;
            double segmentB = segmentA + segmentWidth;

            sum += CalculateSegmentIntegral(f, segmentA, segmentB);
            IterationSolved?.Invoke(this, new IterationSolvedEvemtArgs(i, sum));
        }

        return sum;
    }

    private double CalculateSegmentIntegral(Func<double, double> f, double a, double b)
    {
        double sum = 0.0;
        double detJ = (b - a) / 2;
        double halfLength = detJ;

        for (int i = 0; i < GaussPoints.Length; i++)
        {
            double x = a + halfLength * (GaussPoints[i] + 1);
            sum += detJ * GaussWeights[i] * f(x);
        }

        return sum;
    }
}