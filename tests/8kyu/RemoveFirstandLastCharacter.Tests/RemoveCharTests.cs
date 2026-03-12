namespace RemoveFirstandLastCharacter.Tests;
/// <summary>
/// Contient les tests unitaires paramétrés pour la méthode <see cref="Kata.Remove_char(string)"/>.
/// </summary>
[TestFixture]
public class RemoveCharTests
{
    /// <summary>
    /// Vérifie que la méthode Remove_char supprime correctement le premier et le dernier caractère
    /// pour différents cas de test.
    /// </summary>
    /// <param name="input">Chaîne d'entrée à traiter.</param>
    /// <param name="expected">Résultat attendu après suppression du premier et dernier caractère.</param>
    [TestCase("eloquent", "loquen")]
    [TestCase("country", "ountr")]
    [TestCase("person", "erso")]
    [TestCase("place", "lac")]
    [TestCase("ok", "")]
    public void RemoveChar_ShouldReturnExpectedResults(string input, string expected)
    {
        // Act
        var result = Kata.Remove_char(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected).IgnoreCase, $"Failed on input: {input}");
    }
}