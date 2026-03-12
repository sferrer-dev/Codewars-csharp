namespace ArraysInversion;

/// <summary>
/// Contient des méthodes pour effectuer des opérations sur des tableaux d'entiers.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Retourne un nouveau tableau contenant l'inverse additif de chaque entier du tableau d'entrée.
    /// </summary>
    /// <param name="input">Le tableau d'entiers en entrée.</param>
    /// <returns>Un tableau d'entiers où chaque valeur est l'opposée de celle d'origine.</returns>
    public static int[] InvertValuesLinq(int[] input)
    {
        if (input is null)
            return [];

        return input.Select(value => -value).ToArray();
    }

    /// <summary>
    /// Retourne un nouveau tableau contenant l'inverse additif de chaque entier du tableau d'entrée.
    /// </summary>
    /// <param name="input">Le tableau d'entiers en entrée.</param>
    /// <returns>Un tableau d'entiers où chaque valeur est l'opposée de celle d'origine.</returns>
    public static int[] InvertValues(int[] input)
    {
        if (input is null)
            return [];

        var result = new int[input.Length];

        for (var i = 0; i < input.Length; i++)
        {
            result[i] = -input[i];
        }

        return result;
    }
}
