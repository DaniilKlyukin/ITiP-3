using System.Text;

namespace FractalLibrary;

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
