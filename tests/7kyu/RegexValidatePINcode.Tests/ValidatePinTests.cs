namespace RegexValidatePINcode.Tests;

/// <summary>
/// Classe de tests unitaires pour valider le comportement de la méthode <see cref="Kata.ValidatePin(string)"/>.
/// </summary>
[TestFixture]
public class ValidatePinTests
{
    /// <summary>
    /// Vérifie que la méthode <see cref="Kata.ValidatePin(string)"/> retourne false pour les chaînes
    /// dont la longueur est différente de 4 ou 6 caractères.
    /// </summary>
    [TestCase("1")]
    [TestCase("12")]
    [TestCase("123")]
    [TestCase("12345")]
    [TestCase("1234567")]
    [TestCase("-1234")]
    [TestCase("1.234")]
    [TestCase("-1.234")]
    [TestCase("00000000")]
    [Order(1)]
    public void ValidatePin_ShouldReturnFalse_WhenLengthIsInvalid(string pin)
    {
        Assert.That(Kata.ValidatePin(pin), Is.False, $"Échec pour la valeur \"{pin}\"");
    }

    /// <summary>
    /// Vérifie que la méthode <see cref="Kata.ValidatePin(string)"/> retourne false
    /// pour les chaînes contenant des caractères non numériques.
    /// </summary>
    [TestCase("a234")]
    [TestCase(".234")]
    [TestCase("1234                  ")]
    [Order(2)]
    public void ValidatePin_ShouldReturnFalse_WhenContainsNonDigits(string pin)
    {
        Assert.That(Kata.ValidatePin(pin), Is.False, $"Échec pour la valeur \"{pin}\"");
    }

    /// <summary>
    /// Vérifie que la méthode <see cref="Kata.ValidatePin(string)"/> retourne true
    /// pour des chaînes valides de 4 ou 6 chiffres uniquement.
    /// </summary>
    [TestCase("1234")]
    [TestCase("0000")]
    [TestCase("1111")]
    [TestCase("123456")]
    [TestCase("098765")]
    [TestCase("000000")]
    [TestCase("090909")]
    [Order(3)]
    public void ValidatePin_ShouldReturnTrue_WhenValid(string pin)
    {
        Assert.That(Kata.ValidatePin(pin), Is.True, $"Échec pour la valeur \"{pin}\"");
    }
}
