namespace GeoEngine.Tests;

[TestFixture]
public class VectorTests
{
    [Test]
    public void Constructor_FromPoints_CreatesCorrectVector()
    {
        var start = new Point(1, 2, 3);
        var end = new Point(4, 6, 9);
        var vector = new Vector(start, end);

        Assert.That(vector.X, Is.EqualTo(3));
        Assert.That(vector.Y, Is.EqualTo(4));
        Assert.That(vector.Z, Is.EqualTo(6));
    }

    [Test]
    public void Length_CalculatesCorrectly()
    {
        var vector = new Vector(3, 4, 0);
        Assert.That(vector.Length, Is.EqualTo(5));
    }

    [Test]
    public void AngleBetween_ZeroLengthVector_ThrowsException()
    {
        var v1 = new Vector(1, 0, 0);
        var v2 = new Vector(0, 0, 0);

        Assert.Throws<ArgumentException>(() => GeoEngine.AngleBetween(v1, v2));
    }
}