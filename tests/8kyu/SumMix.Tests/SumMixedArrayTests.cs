namespace SumMixedArray.Tests;

/// <summary>
/// Contient les tests unitaires pour la méthode <see cref="Kata.SumMix(object[])"/>.
/// </summary>
[TestFixture]
public class SumMixedArrayTests
{
    /// <summary>
    /// Vérifie que la méthode <see cref="Kata.SumMix(object[])"/> retourne la somme correcte
    /// pour des tableaux mixtes contenant des entiers et des chaînes de caractères représentant des entiers.
    /// </summary>
    [Test]
    [Order(1)]
    public void SumMix_ShouldReturnCorrectSum_WhenInputIsMixedArray()
    {
        // Arrange & Act & Assert
        Assert.That(Kata.SumMix(new object[] { 9, 3, "7", "3" }), Is.EqualTo(22), "Test case 1 failed");
        Assert.That(Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }), Is.EqualTo(42), "Test case 2 failed");
        Assert.That(Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }), Is.EqualTo(41), "Test case 3 failed");
    }
}
