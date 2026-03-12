using IsDivisibleBy;

namespace IsDivisibleBy.Tests;

[TestFixture]
public class KataChallengeTests
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(KataChallenge.IsDivisible(3, 3, 4), Is.EqualTo(false));
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(KataChallenge.IsDivisible(12, 3, 4), Is.EqualTo(true));
    }
    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(KataChallenge.IsDivisible(100, 5, 4, 10, 25, 20),
                    Is.EqualTo(true),
                    "100 doit être divisible par 5, 4, 10, 25 et 20");
    }
}