using System.Text;

namespace WinFormsApp2
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
            => new(c1.Re + c2.Re, c1.Im + c2.Im);

        public static Complex operator -(Complex c1, Complex c2)
            => new(c1.Re - c2.Re, c1.Im - c2.Im);

        public static Complex operator +(Complex c, double d)
            => new(c.Re + d, c.Im);

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
            => new(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c1.Im * c2.Re);

        public static Complex operator /(Complex c1, Complex c2)
        {
            var conjugate = c2.GetConjugate();

            var c1New = c1 * conjugate;
            var c2New = c2 * conjugate;

            return c1New / c2New.Re;
        }

        public static Complex Pow(Complex c, int power)
        {
            var result = new Complex(c.Re,c.Im);

            for (int i = 0; i < power - 1; i++)
            {
                result *= c;
            }

            return result;
        }

        public Complex GetConjugate()
    => new(Re, -Im);

        public double Magnitude => Math.Sqrt(Re * Re + Im * Im);

        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
        }
        public override string ToString()
        {
            if (Re == 0 && Im == 0)
                return "0";
            var sb = new StringBuilder();

            if (Re != 0)
                sb.Append(Re.ToString());

            if (Im < 0)
            {
                if (Im == -1)
                    sb.Append($"-i");
                else
                    sb.Append($"{Im}i");
            }
            else if (Im > 0)
            {
                if (Re != 0)
                    sb.Append("+");

                if (Im == 1)
                    sb.Append($"i");
                else
                    sb.Append($"{Im}i");
            }
            return sb.ToString();
        }
    }
}