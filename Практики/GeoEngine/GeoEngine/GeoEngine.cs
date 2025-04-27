namespace GeoEngine;

public static class GeoEngine
{
    /// <summary>
    /// Вычисляет скалярное произведение двух векторов
    /// </summary>
    /// <param name="v1">Первый вектор</param>
    /// <param name="v2">Второй вектор</param>
    /// <returns>Скалярное произведение</returns>
    public static double DotProduct(Vector v1, Vector v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }

    /// <summary>
    /// Вычисляет векторное произведение двух векторов
    /// </summary>
    /// <param name="v1">Первый вектор</param>
    /// <param name="v2">Второй вектор</param>
    /// <returns>Новый вектор - результат векторного произведения</returns>
    public static Vector CrossProduct(Vector v1, Vector v2)
    {
        double x = v1.Y * v2.Z - v1.Z * v2.Y;
        double y = v1.Z * v2.X - v1.X * v2.Z;
        double z = v1.X * v2.Y - v1.Y * v2.X;

        return new Vector(x, y, z);
    }

    /// <summary>
    /// Вычисляет угол между двумя векторами в радианах
    /// </summary>
    public static double AngleBetween(Vector v1, Vector v2)
    {
        double dot = DotProduct(v1, v2);
        double lengths = v1.Length * v2.Length;

        if (lengths < 1e-10)
            throw new ArgumentException("Один из векторов имеет нулевую длину");

        // Убедимся, что значение в пределах [-1, 1] из-за ошибок округления
        double cos = dot / lengths;
        cos = Math.Clamp(cos, -1, 1);

        return Math.Acos(cos);
    }

    /// <summary>
    /// Проверяет, являются ли векторы коллинеарными
    /// </summary>
    public static bool AreCollinear(Vector v1, Vector v2, double tolerance = 1e-10)
    {
        var cross = CrossProduct(v1, v2);
        return Math.Abs(cross.X) < tolerance &&
               Math.Abs(cross.Y) < tolerance &&
               Math.Abs(cross.Z) < tolerance;
    }
}