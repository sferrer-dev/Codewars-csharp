using NUnit.Framework;

namespace OppositesAttract.Tests;

/// <summary>
/// Tests unitaires pour la méthode <c>lovefunc</c> de la classe <c>LoveDetector</c>.
/// Vérifie si deux nombres indiquent des nombres opposés (pair et impair).
/// </summary>
[TestFixture]
public class LoveTests
{
    /// <summary>
    /// Vérifie plusieurs cas de figure pour s'assurer que la méthode
    /// <c>lovefunc</c> retourne <c>true</c> lorsque les entiers ont une parité opposée
    /// et <c>false</c> lorsqu'ils ont la même parité.
    /// </summary>
    /// <param name="a">Premier entier.</param>
    /// <param name="b">Deuxième entier.</param>
    /// <param name="expected">Résultat attendu.</param>
    [TestCase(1, 4, true, TestName = "Impair et Pair => true")]
    [TestCase(2, 2, false, TestName = "Pair et Pair => false")]
    [TestCase(0, 1, true, TestName = "Pair et Impair => true")]
    [TestCase(0, 0, false, TestName = "Pair et Pair (0,0) => false")]
    public void LoveFunc_ShouldReturnExpectedResult(int a, int b, bool expected)
    {
        // Act & Assert
        Assert.That(LoveDetector.lovefunc(a, b), Is.EqualTo(expected));
    }
}
