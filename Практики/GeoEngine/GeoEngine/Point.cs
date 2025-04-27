namespace GeoEngine;

public class Point
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Point other) return false;
        return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}
