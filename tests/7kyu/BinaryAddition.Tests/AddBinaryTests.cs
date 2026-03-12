namespace BinaryAddition;

using NUnit.Framework;

/// <summary>
/// Tests unitaires pour la méthode AddBinary.
/// </summary>
[TestFixture]
public class AddBinaryTests
{
    /// <summary>
    /// Vérifie l'exemple fourni dans l'énoncé du kata.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn11_WhenAdding1And2()
    {
        // Arrange
        int a = 1;
        int b = 2;

        // Act
        string result = Kata.AddBinary(a, b);

        // Assert
        Assert.That(result, Is.EqualTo("11"), "Should return \"11\" for 1 + 2");
    }

    /// <summary>
    /// Vérifie l'addition de deux valeurs égales.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn10_WhenAdding1And1()
    {
        Assert.That(Kata.AddBinary(1, 1), Is.EqualTo("10"));
    }

    /// <summary>
    /// Vérifie la conversion binaire pour une somme plus grande.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn1110_WhenAdding5And9()
    {
        Assert.That(Kata.AddBinary(5, 9), Is.EqualTo("1110"));
    }

    /// <summary>
    /// Vérifie que la méthode fonctionne avec zéro.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn0_WhenAdding0And0()
    {
        Assert.That(Kata.AddBinary(0, 0), Is.EqualTo("0"));
    }

    /// <summary>
    /// Vérifie une addition simple produisant un nombre binaire court.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn100_WhenAdding2And2()
    {
        Assert.That(Kata.AddBinary(2, 2), Is.EqualTo("100"));
    }

    /// <summary>
    /// Vérifie une addition produisant un nombre binaire plus long.
    /// </summary>
    [Test]
    public void AddBinary_ShouldReturn10100_WhenAdding10And10()
    {
        Assert.That(Kata.AddBinary(10, 10), Is.EqualTo("10100"));
    }
}