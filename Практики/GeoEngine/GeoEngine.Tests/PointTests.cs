namespace GeoEngine.Tests;

[TestFixture]
public class PointTests
{
    [Test]
    public void Constructor_SetsCoordinates()
    {
        var point = new Point(1.5, 2.5, 3.5);

        Assert.That(point.X, Is.EqualTo(1.5));
        Assert.That(point.Y, Is.EqualTo(2.5));
        Assert.That(point.Z, Is.EqualTo(3.5));
    }

    [Test]
    public void Equals_ReturnsTrueForSamePoints()
    {
        var p1 = new Point(1, 2, 3);
        var p2 = new Point(1, 2, 3);

        Assert.That(p1.Equals(p2), Is.True);
    }
}