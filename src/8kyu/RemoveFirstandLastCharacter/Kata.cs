namespace RemoveFirstandLastCharacter;

/// <summary>
/// Contient les méthodes utilitaires liées à la manipulation de chaînes.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Supprime le premier et le dernier caractère d'une chaîne de caractères.
    /// </summary>
    /// <param name="s">La chaîne d'entrée.</param>
    /// <returns>La chaîne sans son premier et dernier caractère, ou une chaîne vide si sa longueur est inférieure ou égale à 2.</returns>
    public static string Remove_char(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length <= 2)
            return string.Empty;

        return s.Substring(1, s.Length - 2);
    }
}
