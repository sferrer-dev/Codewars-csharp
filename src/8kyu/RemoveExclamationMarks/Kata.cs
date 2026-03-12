namespace RemoveExclamationMarks;

/// <summary>
/// Fournit des méthodes utilitaires pour la manipulation des chaînes de caractères.
/// </summary>
public class Kata
{
    /// <summary>
    /// Supprime tous les points d'exclamation d'une chaîne de caractères donnée.
    /// </summary>
    /// <param name="input">La chaîne de caractères à traiter.</param>
    /// <returns>Une nouvelle chaîne sans aucun point d'exclamation.</returns>
    public static string RemoveExclamationMarks(string input)
    {
        if (input == null)
            return string.Empty;

        return input.Replace("!", string.Empty);
    }
}
