namespace BitCounting.Tests;

using NUnit.Framework;

/// <summary>
/// Tests unitaires vérifiant le bon fonctionnement
/// de la méthode CountBits du kata Bit Counting.
/// </summary>
[TestFixture]
public class CountBitsTests
{
    /// <summary>
    /// Vérifie plusieurs cas connus provenant de Codewars.
    /// </summary>
    [TestCase(0, 0)]
    [TestCase(4, 1)]
    [TestCase(7, 3)]
    [TestCase(12525589, 11)]
    [TestCase(3811, 8)]
    [TestCase(392902058, 17)]
    [TestCase(1044, 3)]
    [TestCase(10030245, 10)]
    [TestCase(89, 4)]
    [TestCase(674259, 10)]
    [TestCase(int.MaxValue, 31)]
    public void CountBits_ShouldReturnExpectedNumberOfSetBits(int input, int expected)
    {
        // Act
        int actual = Kata.CountBits(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
