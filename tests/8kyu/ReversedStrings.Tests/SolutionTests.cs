namespace ReversedStrings.Tests;

/// <summary>
/// Tests unitaires pour la classe <see cref="StringReverser"/>.
/// </summary>
[TestFixture]
public class StringReverserTests
{
    /// <summary>
    /// Vérifie que la méthode Solution retourne bien la chaîne inversée attendue.
    /// </summary>
    [Test]
    public void Solution_ShouldReturnReversedString_WhenInputIsValid()
    {
        // Arrange
        string input = "world";
        string expected = "dlrow";

        // Act
        string result = Kata.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode SolutionLinq retourne bien la chaîne inversée attendue.
    /// </summary>
    [Test]
    public void SolutionLinq_ShouldReturnReversedString_WhenInputIsValid()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Act
        string result = Kata.SolutionLinq(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
