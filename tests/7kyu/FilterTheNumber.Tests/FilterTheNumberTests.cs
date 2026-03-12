namespace FilterTheNumber.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTests()
    {
        Assert.That(Kata.FilterString("123"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterString("a1b2c3"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterString("aa1bb2cc3dd"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterStringWithoutLinq("123"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterStringWithoutLinq("a1b2c3"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterStringWithoutLinq("aa1bb2cc3dd"), Is.EqualTo(123), "Just return the numbers");
    }
}