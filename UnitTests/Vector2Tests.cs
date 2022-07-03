using Application.Math;

namespace UnitTests;

public class Vector2Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void TestEquality()
    {
        var v = new Vector2(1, 2);
        var u = new Vector2(1, 2);

        Assert.That(v, Is.EqualTo(u));
    }
    
    [Test]
    public void TestDoublePrecisionEquality()
    {
        var v = new Vector2(0.1, 0.2);
        var u = new Vector2(0.100000001, 0.200000001);

        Assert.That(v, Is.EqualTo(u));
    }

    [Test]
    public void TestLength()
    {
        Assert.That(new Vector2(3, 4).Length(), Is.EqualTo(5));
    }

    [Test]
    public void TestNormalization()
    {
        var actual = new Vector2(3, 4).Normalize();
        var expected = new Vector2(0.6, 0.8);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestScaling()
    {
        var actual = new Vector2(3, 4).Scale(3);
        var expected = new Vector2(1.8, 2.4);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestTwoVectorsAdding()
    {
        var v = new Vector2(1, 2);
        var u = new Vector2(3, 4);
        var a = new Vector2(-5, -3);
        Assert.Multiple(() =>
        {
            Assert.That(v.Add(u), Is.EqualTo(new Vector2(4, 6)));
            Assert.That(u.Add(a), Is.EqualTo(new Vector2(-2, 1)));
        });
    }
    
    [Test]
    public void TestVectorAndScalarsAdding()
    {
        var v = new Vector2(1, 2);
        Assert.Multiple(() =>
        {
            Assert.That(v.Add(3, 4), Is.EqualTo(new Vector2(4, 6)));
            Assert.That(v.Add(-5, -3), Is.EqualTo(new Vector2(-4, -1)));
        });
    }
    
    [Test]
    public void TestTwoVectorsSubtracting()
    {
        var v = new Vector2(1, 2);
        var u = new Vector2(3, 4);
        var a = new Vector2(-5, -3);
        Assert.Multiple(() =>
        {
            Assert.That(v.Subtract(u), Is.EqualTo(new Vector2(-2, -2)));
            Assert.That(u.Subtract(a), Is.EqualTo(new Vector2(8, 7)));
        });
    }
    
    [Test]
    public void TestVectorAndScalarsSubtracting()
    {
        var v = new Vector2(1, 2);
        Assert.Multiple(() =>
        {
            Assert.That(v.Subtract(3, 4), Is.EqualTo(new Vector2(-2, -2)));
            Assert.That(v.Subtract(-5, -3), Is.EqualTo(new Vector2(6, 5)));
        });
    }

}