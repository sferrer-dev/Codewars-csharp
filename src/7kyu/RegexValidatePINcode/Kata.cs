using System.Text.RegularExpressions;

namespace RegexValidatePINcode;

/// <summary>
/// Contient des méthodes utilitaires pour la validation de chaînes représentant un code PIN.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Valide si une chaîne donnée est un code PIN correct.
    /// Un code PIN valide est constitué uniquement de chiffres et sa longueur est soit 4, soit 6 caractères.
    /// </summary>
    /// <param name="pin">La chaîne représentant le code PIN à valider.</param>
    /// <returns><c>true</c> si le PIN est valide ; sinon <c>false</c>.</returns>
    /// <exception cref="ArgumentNullException">Lancé si la chaîne <paramref name="pin"/> est null.</exception>
    public static bool ValidatePinLinq(string pin)
    {
        if (pin is null)
            throw new ArgumentNullException(nameof(pin), "Le code PIN ne peut pas être null.");

        return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
    }

    /// <summary>
    /// Valide si une chaîne donnée est un code PIN correct.
    /// Un code PIN valide est constitué uniquement de chiffres et sa longueur est soit 4, soit 6 caractères.
    /// </summary>
    /// <param name="pin">La chaîne représentant le code PIN à valider.</param>
    /// <returns><c>true</c> si le PIN est valide ; sinon <c>false</c>.</returns>
    /// <exception cref="ArgumentNullException">Lancé si la chaîne <paramref name="pin"/> est null.</exception>
    public static bool ValidatePin(string pin)
    {
        if (pin is null)
            throw new ArgumentNullException(nameof(pin), "Le code PIN ne peut pas être null.");

        return Regex.IsMatch(pin, @"^\d{4}$|^\d{6}$") && (pin.Length == 4 || pin.Length == 6);
    }
}
