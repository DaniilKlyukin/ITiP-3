namespace GeoEngine.Tests;

[TestFixture]
public class GeoEngineTests
{
    [Test]
    public void DotProduct_OrthogonalVectors_ReturnsZero()
    {
        var v1 = new Vector(1, 0, 0);
        var v2 = new Vector(0, 1, 0);

        var result = GeoEngine.DotProduct(v1, v2);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CrossProduct_StandardBasisVectors_ReturnsThirdBasisVector()
    {
        var v1 = new Vector(1, 0, 0);
        var v2 = new Vector(0, 1, 0);

        var result = GeoEngine.CrossProduct(v1, v2);

        Assert.That(result, Is.EqualTo(new Vector(0, 0, 1)));
    }

    [Test]
    public void AngleBetween_ParallelVectors_ReturnsZero()
    {
        var v1 = new Vector(1, 0, 0);
        var v2 = new Vector(2, 0, 0);

        var angle = GeoEngine.AngleBetween(v1, v2);

        Assert.That(angle, Is.EqualTo(0).Within(1e-10));
    }

    [Test]
    public void AreCollinear_ParallelVectors_ReturnsTrue()
    {
        var v1 = new Vector(1, 2, 3);
        var v2 = new Vector(2, 4, 6);

        Assert.That(GeoEngine.AreCollinear(v1, v2), Is.True);
    }
}