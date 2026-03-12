namespace MostTopWords.Tests;

/// <summary>
/// Tests unitaires pour la classe TopWords.
/// </summary>
[TestFixture]
public class TopWordsTests
{
    [Test]
    public void Top3_Should_Return_Most_Frequent_Words()
    {
        Assert.That(
            TopWords.Top3("a a a  b  c c  d d d d  e e e e e"),
            Is.EqualTo(new List<string> { "e", "d", "a" })
        );

        Assert.That(
            TopWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"),
            Is.EqualTo(new List<string> { "e", "ddd", "aa" })
        );

        Assert.That(
            TopWords.Top3("  //wont won't won't "),
            Is.EqualTo(new List<string> { "won't", "wont" })
        );

        Assert.That(
            TopWords.Top3("  , e   .. "),
            Is.EqualTo(new List<string> { "e" })
        );

        Assert.That(
            TopWords.Top3("  ...  "),
            Is.EqualTo(new List<string>())
        );

        Assert.That(
            TopWords.Top3("  '  "),
            Is.EqualTo(new List<string>())
        );

        Assert.That(
            TopWords.Top3("  '''  "),
            Is.EqualTo(new List<string>())
        );
    }

    [Test]
    public void Top3_Should_Work_With_Large_Text()
    {
        var expected = new List<string> { "a", "of", "on" };

        var text = string.Join("\n", new string[]
        {
            "In a village of La Mancha, the name of which I have no desire to call to",
            "mind, there lived not long since one of those gentlemen that keep a lance",
            "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
            "coursing. An olla of rather more beef than mutton, a salad on most",
            "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
            "on Sundays, made away with three-quarters of his income."
        });

        Assert.That(TopWords.Top3(text), Is.EqualTo(expected));
    }
}
