namespace ArraysInversion.Tests;

/// <summary>
/// Classe de tests pour vérifier la méthode <c>InvertValues</c> de la classe <c>Kata</c>.
/// </summary>
[TestFixture]
public class ArraysInversionTests
{
    /// <summary>
    /// Fournit plusieurs jeux de données pour tester le retournement des valeurs d’un tableau.
    /// </summary>
    private static readonly object[] TestCases =
    {
        new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { -1, -2, -3, -4, -5 } },
        new object[] { new[] { 1, -2, 3, -4, 5 }, new[] { -1, 2, -3, 4, -5 } },
        new object[] { new int[] { }, new int[] { } },
        new object[] { new[] { 0 }, new[] { 0 } }
    };

    /// <summary>
    /// Vérifie que <c>InvertValues</c> retourne le tableau avec les signes inversés pour chaque élément.
    /// </summary>
    /// <param name="input">Le tableau d'entiers en entrée.</param>
    /// <param name="expected">Le tableau attendu après inversion des signes.</param>
    [Test, TestCaseSource(nameof(TestCases))]
    public void InvertValues_ShouldReturnExpectedResults(int[] input, int[] expected)
    {
        // Act
        var result = Kata.InvertValues(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}