namespace SortingByBits.Tests;

using NUnit.Framework;

/// <summary>
/// Tests unitaires pour la méthode SortByBit du kata Sorting by bits.
/// </summary>
[TestFixture]
public class SortByBitTests
{
    /// <summary>
    /// Vérifie que le tableau est correctement trié
    /// selon le nombre de bits puis la valeur.
    /// </summary>
    [TestCase(
        new[] { 3, 8, 3, 6, 5, 7, 9, 1 },
        new[] { 1, 8, 3, 3, 5, 6, 9, 7 })]

    [TestCase(
        new[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 },
        new[] { 0, 2, 2, 4, 8, 8, 3, 5, 5, 6, 9, 7, 56 })]
    public void SortByBit_ShouldSortArrayByBitCountThenValue(int[] input, int[] expected)
    {
        // Act
        int[] result = Kata.SortByBit(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
