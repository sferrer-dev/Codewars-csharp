namespace RemoveExclamationMarks.Tests;

/// <summary>
/// Contient les tests unitaires pour la méthode RemoveExclamationMarks.
/// </summary>
[TestFixture]
public class RemoveExclamationMarksTests
{
    /// <summary>
    /// Vérifie que la méthode RemoveExclamationMarks retourne une chaîne vide lorsque l'entrée est vide.
    /// </summary>
    [Test]
    public void Given_EmptyString_Should_ReturnEmptyString()
    {
        // Arrange
        var input = string.Empty;

        // Act
        var result = Kata.RemoveExclamationMarks(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    /// <summary>
    /// Vérifie que la méthode RemoveExclamationMarks supprime un seul point d'exclamation.
    /// </summary>
    [Test]
    public void Given_SingleExclamationMark_Should_ReturnEmptyString()
    {
        var result = Kata.RemoveExclamationMarks("!");
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    /// <summary>
    /// Vérifie que la méthode RemoveExclamationMarks supprime plusieurs points d'exclamation.
    /// </summary>
    [Test]
    public void Given_MultipleExclamationMarks_Should_ReturnEmptyString()
    {
        var result = Kata.RemoveExclamationMarks("!!");
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    /// <summary>
    /// Vérifie que la méthode RemoveExclamationMarks supprime les points d'exclamation d'une chaîne normale.
    /// </summary>
    [Test]
    public void Given_TextWithExclamationMark_Should_RemoveExclamationMark()
    {
        var result = Kata.RemoveExclamationMarks("Hi!");
        Assert.That(result, Is.EqualTo("Hi"));
    }

    /// <summary>
    /// Vérifie que la méthode RemoveExclamationMarks supprime uniquement les points d'exclamation, en gardant les autres caractères.
    /// </summary>
    [Test]
    public void Given_TextWithMixedCharacters_Should_RemoveOnlyExclamationMarks()
    {
        var result = Kata.RemoveExclamationMarks("!?!");
        Assert.That(result, Is.EqualTo("?"));
    }
}
