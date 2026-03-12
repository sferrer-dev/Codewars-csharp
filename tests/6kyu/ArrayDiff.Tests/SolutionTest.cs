namespace ArrayDiff.Tests;

[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2 }));
        Assert.That(Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2, 2 }));
        Assert.That(Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }), Is.EqualTo(new int[] { 1 }));
        Assert.That(Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }), Is.EqualTo(new int[] { 1, 2, 2 }));
        Assert.That(Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }), Is.EqualTo(new int[] { }));
        Assert.That(Kata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }), Is.EqualTo(new int[] { 3 }));
    }
}