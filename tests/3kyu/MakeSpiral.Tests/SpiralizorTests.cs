namespace MakeSpiral.Tests;

using NUnit.Framework;

/// <summary>
/// Contient les tests unitaires de la classe <see cref="Spiralizor"/>.
/// </summary>
[TestFixture]
public class SpiralizorTests
{
    [Test]
    public void Spiralize_Should_Return_Expected_Spiral_For_Size_5()
    {
        // Arrange
        int size = 5;
        int[,] expected =
        {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 }
        };

        // Act
        int[,] actual = Spiralizor.Spiralize(size);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Spiralize_Should_Return_Expected_Spiral_For_Size_8()
    {
        // Arrange
        int size = 8;
        int[,] expected =
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1 }
        };

        // Act
        int[,] actual = Spiralizor.Spiralize(size);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}