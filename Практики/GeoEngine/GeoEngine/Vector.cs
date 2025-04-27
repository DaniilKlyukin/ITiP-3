namespace GeoEngine;

public class Vector
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector(Point start, Point end)
    {
        X = end.X - start.X;
        Y = end.Y - start.Y;
        Z = end.Z - start.Z;
    }

    public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

    public override bool Equals(object? obj)
    {
        if (obj is not Vector other) return false;
        return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public override string ToString()
    {
        return $"[{X}, {Y}, {Z}]";
    }
}