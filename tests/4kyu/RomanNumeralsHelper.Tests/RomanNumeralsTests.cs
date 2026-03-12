namespace RomanNumeralsHelper.Tests;

/// <summary>
/// Contient les tests unitaires de la classe <c>RomanNumerals</c>.
/// </summary>
[TestFixture]
public class RomanNumeralsTests
{
    /// <summary>
    /// Vérifie que la méthode <c>ToRoman</c> convertit correctement un entier en nombre romain.
    /// </summary>
    /// <param name="input">Valeur entière à convertir.</param>
    /// <param name="expected">Valeur romaine attendue.</param>
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(9, "IX")]
    [TestCase(58, "LVIII")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(1666, "MDCLXVI")]
    public void ToRoman_Should_Return_Expected_Roman_Numeral(int input, string expected)
    {
        // Act
        string actual = RomanNumerals.ToRoman(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode <c>FromRoman</c> convertit correctement un nombre romain en entier.
    /// </summary>
    /// <param name="input">Valeur romaine à convertir.</param>
    /// <param name="expected">Valeur entière attendue.</param>
    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("IV", 4)]
    [TestCase("IX", 9)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXC", 1990)]
    [TestCase("MMVIII", 2008)]
    [TestCase("MDCLXVI", 1666)]
    public void FromRoman_Should_Return_Expected_Integer(string input, int expected)
    {
        // Act
        int actual = RomanNumerals.FromRoman(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode <c>FromRoman</c> convertit correctement un nombre romain en entier.
    /// </summary>
    /// <param name="input">Valeur romaine à convertir.</param>
    /// <param name="expected">Valeur entière attendue.</param>
    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("IV", 4)]
    [TestCase("IX", 9)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXC", 1990)]
    [TestCase("MMVIII", 2008)]
    [TestCase("MDCLXVI", 1666)]
    public void FromRomanV2_Should_Return_Expected_Integer(string input, int expected)
    {
        // Act
        int actual = RomanNumerals.FromRomanV2(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}