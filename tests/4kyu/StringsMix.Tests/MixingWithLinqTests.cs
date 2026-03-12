namespace StringsMix.Tests;

/// <summary>
/// Tests unitaires pour la méthode <see cref="Mixing.Mix(string, string)"/>.
/// </summary>
[TestFixture]
public class MixingWithLinqTests
{
    /// <summary>
    /// Vérifie que la méthode Mix retourne le résultat attendu
    /// pour différents jeux de données provenant des exemples du kata.
    /// </summary>
    /// <param name="s1">Première chaîne à analyser.</param>
    /// <param name="s2">Deuxième chaîne à analyser.</param>
    /// <param name="expected">Résultat attendu.</param>
    [TestCase("Are they here", "yes, they are here", "2:eeeee/2:yy/=:hh/=:rr")]
    [TestCase("looping is fun but dangerous", "less dangerous than coding", "1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg")]
    [TestCase(" In many languages", " there's a pair of functions", "1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt")]
    [TestCase("Lords of the Fallen", "gamekult", "1:ee/1:ll/1:oo")]
    [TestCase("codewars", "codewars", "")]
    [TestCase("A generation must confront the looming ", "codewarrs", "1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr")]
    public void Mix_Should_ReturnExpectedResult_When_ValidInputsAreProvided(
        string s1,
        string s2,
        string expected)
    {
        // Arrange
        // (les données sont fournies par TestCase)

        // Act
        string result = Mixing.MixWithLinq(s1, s2);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}