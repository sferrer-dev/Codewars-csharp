namespace AlphabetPosition.Tests;

using NUnit.Framework;

/// <summary>
/// Tests unitaires de la classe <see cref="Kata"/>.
/// Vérifie la conversion correcte des lettres en positions alphabétiques.
/// </summary>
[TestFixture]
public class AlphabetPositionTests
{
    /// <summary>
    /// Vérifie les exemples fournis dans l'énoncé du kata.
    /// </summary>
    [Test, Order(1)]
    public void AlphabetPosition_Should_Return_Expected_Positions_For_Sample_Texts()
    {
        Assert.That(
            Kata.AlphabetPosition("The sunset sets at twelve o' clock."),
            Is.EqualTo("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11")
        );

        Assert.That(
            Kata.AlphabetPosition("The narwhal bacons at midnight."),
            Is.EqualTo("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20")
        );
    }

    /// <summary>
    /// Vérifie que les caractères non alphabétiques sont ignorés.
    /// </summary>
    [Test]
    public void AlphabetPosition_Should_Ignore_Non_Letter_Characters()
    {
        Assert.That(Kata.AlphabetPosition("123 !@#"), Is.EqualTo(""));
    }

    /// <summary>
    /// Vérifie le fonctionnement avec une seule lettre.
    /// </summary>
    [Test]
    public void AlphabetPosition_Should_Return_Single_Position()
    {
        Assert.That(Kata.AlphabetPosition("a"), Is.EqualTo("1"));
        Assert.That(Kata.AlphabetPosition("Z"), Is.EqualTo("26"));
    }

    /// <summary>
    /// Vérifie le fonctionnement avec un alphabet complet.
    /// </summary>
    [Test]
    public void AlphabetPosition_Should_Handle_Full_Alphabet()
    {
        Assert.That(
            Kata.AlphabetPosition("abcdefghijklmnopqrstuvwxyz"),
            Is.EqualTo("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26")
        );
    }
}