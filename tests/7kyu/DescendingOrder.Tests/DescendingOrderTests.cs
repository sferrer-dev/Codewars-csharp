namespace DescendingOrder.Tests;

using NUnit.Framework;

/// <summary>
/// Tests unitaires pour la méthode DescendingOrder.
/// </summary>
[TestFixture]
public class DescendingOrderTests
{
    /// <summary>
    /// Vérifie que la fonction retourne 0 lorsque l'entrée vaut 0.
    /// </summary>
    [Test]
    public void DescendingOrder_ShouldReturnZero_WhenInputIsZero()
    {
        Assert.That(Kata.DescendingOrder(0), Is.EqualTo(0));
    }

    [Test]
    public void DescendingOrderLinq_ShouldReturnZero_WhenInputIsZero()
    {
        Assert.That(Kata.DescendingOrderLinq(0), Is.EqualTo(0));
    }

    /// <summary>
    /// Vérifie que les chiffres sont correctement triés en ordre décroissant.
    /// </summary>
    [TestCase(42145, 54421)]
    [TestCase(145263, 654321)]
    [TestCase(123456789, 987654321)]
    public void DescendingOrder_ShouldSortDigitsDescending(int input, int expected)
    {
        int result = Kata.DescendingOrderLinq(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie le comportement avec un nombre contenant des chiffres identiques.
    /// </summary>
    [Test]
    public void DescendingOrder_ShouldHandleDuplicateDigits()
    {
        int result = Kata.DescendingOrderLinq(111222);

        Assert.That(result, Is.EqualTo(222111));
    }

    /// <summary>
    /// Vérifie le comportement avec un nombre déjà trié.
    /// </summary>
    [Test]
    public void DescendingOrder_ShouldReturnSameNumber_WhenAlreadyDescending()
    {
        int result = Kata.DescendingOrderLinq(987654);

        Assert.That(result, Is.EqualTo(987654));
    }

    /// <summary>
    /// Vérifie le comportement avec un seul chiffre.
    /// </summary>
    [Test]
    public void DescendingOrder_ShouldReturnSameDigit_WhenSingleDigit()
    {
        int result = Kata.DescendingOrderLinq(7);

        Assert.That(result, Is.EqualTo(7));
    }

    /// <summary>
    /// Vérifie que les chiffres sont triés par ordre décroissant
    /// sur plusieurs cas représentatifs.
    /// </summary>
    [TestCase(42145, 54421)]
    [TestCase(145263, 654321)]
    [TestCase(123456789, 987654321)]
    [TestCase(111222, 222111)]
    [TestCase(900000001, 910000000)]
    public void DescendingOrder_ShouldSortDigitsInDescendingOrder(int input, int expected)
    {
        int actual = Kata.DescendingOrder(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie qu'un nombre déjà en ordre décroissant reste inchangé.
    /// </summary>
    [Test]
    public void DescendingOrder_ShouldReturnSameValue_WhenDigitsAreAlreadySorted()
    {
        Assert.That(Kata.DescendingOrder(965410), Is.EqualTo(965410));
    }

    /// <summary>
    /// Vérifie qu'un nombre à un seul chiffre reste inchangé.
    /// </summary>
    [TestCase(1)]
    [TestCase(5)]
    [TestCase(9)]
    public void DescendingOrder_ShouldReturnSameValue_WhenInputHasSingleDigit(int input)
    {
        Assert.That(Kata.DescendingOrder(input), Is.EqualTo(input));
    }
}