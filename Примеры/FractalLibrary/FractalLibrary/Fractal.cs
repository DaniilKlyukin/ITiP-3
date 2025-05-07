using System.Drawing;
using System.Numerics;
using System.Text;

namespace FractalLibrary;

public class Fractal
{
    public const double R_MIN = 0.01;

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
    public int[,] Calculate()
    {
        var values = new int[Rows, Columns];

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                var x = CenterX + Width * j / (Columns - 1) - Width / 2;
                var y = CenterY + Height * i / (Rows - 1) - Height / 2;

                var z = new Complex(x, y);

                var iterations = 0;

                while (z.Pow(3).Magnitude > R_MIN && iterations <= IterationsLimit)
                {
                    z -= f(z) / df(z);

                    iterations++;
                }

                values[i, j] = iterations;
            }
        }

        return values;
    }

    private Complex f(Complex z) => z.Pow(3) - 1;

    private Complex df(Complex z) => 3 * z.Pow(2);
}

public class Complex
{
    public double Re { get; set; } // Вещественная часть
    public double Im { get; set; } // Мнимая часть

    public double Magnitude => Math.Sqrt(Re * Re + Im * Im);

    public Complex(double re = 0, double im = 0)
    {
        Re = re;
        Im = im;
    }

    // Определяем оператор сложения для объектов типа Complex
    public static Complex operator +(Complex c1, Complex c2)
        => new(c1.Re + c2.Re, c1.Im + c2.Im);
    // Определяем оператор вычитания для объектов типа Complex
    public static Complex operator -(Complex c1, Complex c2)
        => new(c1.Re - c2.Re, c1.Im - c2.Im);

    // Определяем оператор сложения Complex и double
    public static Complex operator +(Complex c, double d)
        => new(c.Re + d, c.Im);
    // Операции по умолчанию не коммутативны
    public static Complex operator -(double d, Complex c)
        => new(d - c.Re, c.Im);

    public static Complex operator +(double d, Complex c)
        => c + d;

    public static Complex operator -(Complex c, double d)
        => new(c.Re - d, c.Im);

    public static Complex operator *(Complex c, double d)
        => new(d * c.Re, d * c.Im);

    public static Complex operator *(double d, Complex c)
        => c * d;
    public static Complex operator /(Complex c, double d)
        => new(c.Re / d, c.Im / d);

    public static Complex operator *(Complex c1, Complex c2)
        => new(c1.Re * c2.Re - c1.Im * c2.Im,
                        c1.Re * c2.Im + c1.Im * c2.Re);

    public static Complex operator /(Complex c1, Complex c2)
    {
        var conjugate = c2.GetConjugate();

        var c1New = c1 * conjugate;
        var c2New = c2 * conjugate;

        return c1New / c2New.Re;
    }
    // Сопряженное комплексное число
    public Complex GetConjugate()
        => new(Re, -Im);

    // Неявное преобразование вещественного числа в комплексное
    public static implicit operator Complex(double d)
      => new(d, 0);

    // Явное преобразование комплексного числа в вещественное с отбрасыванием мнимой части
    public static explicit operator double(Complex c)
      => c.Re;

    public Complex Pow(int degree)
    {
        var current = new Complex(Re, Im);

        for (int i = 1; i < degree; i++)
        {
            current *= this;
        }

        return current;
    }

    public override string ToString() // Для красивого вывода на экран
    {
        if (Re == 0 && Im == 0)
            return "0";
        var sb = new StringBuilder();
        if (Re != 0) sb.Append(Re.ToString());
        if (Im < 0)
        {
            if (Im == -1) sb.Append($"-i");
            else sb.Append($"{Im}i");
        }
        else if (Im > 0)
        {
            if (Re != 0) sb.Append("+");
            if (Im == 1) sb.Append($"i");
            else sb.Append($"{Im}i");
        }
        return sb.ToString();
    }
}

/// <summary>
/// Класс для перевода сеточных значений ячеек в цвета
/// </summary>
public interface IPainter
{
    public Color[,] Paint(int[,] gridValues);
}

/// <summary>
/// Класс для перевода сеточных значений ячеек в ЧБ цвета
/// </summary>
public class GrayScalePainter : IPainter
{
    public Color[,] Paint(int[,] gridValues)
    {
        var min = gridValues.Min();
        var max = gridValues.Max();

        var rows = gridValues.GetLength(0);
        var columns = gridValues.GetLength(1);

        var colors = new Color[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                var norm = (gridValues[i, j] - min) / (max - min);

                var colorValue = (int)(255.0 * norm);

                colors[i, j] = Color.FromArgb(255, colorValue, colorValue, colorValue);
            }
        }

        return colors;
    }
}

public static class ArrayExtensions
{
    public static T Min<T>(this T[,] values) where T : INumber<T>
    {
        var rows = values.GetLength(0);
        var columns = values.GetLength(1);

        var min = values[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (values[i, j] < min)
                    min = values[i, j];
            }
        }

        return min;
    }

    public static T Max<T>(this T[,] values) where T : INumber<T>
    {
        var rows = values.GetLength(0);
        var columns = values.GetLength(1);

        var max = values[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (values[i, j] > max)
                    max = values[i, j];
            }
        }

        return max;
    }
}