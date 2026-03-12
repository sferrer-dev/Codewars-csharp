namespace SimplePigLatin.Tests;

[TestFixture]
public class SimplePigLatinTest
{
    [TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
    [TestCase("This is my string", "hisTay siay ymay tringsay")]
    public void PigIt_Should_Convert_Sentence_To_PigLatin(string input, string expected)
    {
        Assert.That(Kata.PigIt(input), Is.EqualTo(expected));
    }

    [TestCase("Pig latin is cool", "igPay atinlay siay oolcay")]
    [TestCase("This is my string", "hisTay siay ymay tringsay")]
    public void PigItLinq_Should_Convert_Sentence_To_PigLatin(string input, string expected)
    {
        Assert.That(Kata.PigItLinq(input), Is.EqualTo(expected));
    }

    [Test]
    public void PigIt_Should_Ignore_Punctuation()
    {
        Assert.That(Kata.PigIt("Hello world !"), Is.EqualTo("elloHay orldway !"));
    }

    [Test]
    public void PigItLinq_Should_Ignore_Punctuation()
    {
        Assert.That(Kata.PigItLinq("Hello world !"), Is.EqualTo("elloHay orldway !"));
    }
}