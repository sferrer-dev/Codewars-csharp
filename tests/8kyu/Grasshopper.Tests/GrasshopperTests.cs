using Grasshopper;

namespace Grasshopper.Tests;

[TestFixture]
public class GrasshopperTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Order(1)]
    public static void BasicTests()
    {
        Assert.That(Kata.summation(1), Is.EqualTo(1));
        Assert.That(Kata.summation(8), Is.EqualTo(36));
        Assert.That(Kata.summation(22), Is.EqualTo(253));
        Assert.That(Kata.summation(100), Is.EqualTo(5050));
        Assert.That(Kata.summation(213), Is.EqualTo(22791));
    }
}