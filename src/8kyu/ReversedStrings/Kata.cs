namespace ReversedStrings;

/// <summary>
/// Fournit des méthodes utilitaires pour inverser des chaînes de caractères.
/// </summary>
public class Kata
{
    /// <summary>
    /// Renverse une chaîne de caractères en utilisant LINQ.
    /// </summary>
    /// <param name="str">Chaîne à inverser.</param>
    /// <returns>Chaîne inversée.</returns>
    public static string SolutionLinq(string str)
    {
        return new string(str.Reverse().ToArray());
    }

    /// <summary>
    /// Renverse une chaîne de caractères sans utiliser LINQ.
    /// </summary>
    /// <param name="str">Chaîne à inverser.</param>
    /// <returns>Chaîne inversée.</returns>
    public static string Solution(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        char[] characters = new char[str.Length];

        for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        {
            characters[i] = str[j];
        }

        return new string(characters);
    }
}
