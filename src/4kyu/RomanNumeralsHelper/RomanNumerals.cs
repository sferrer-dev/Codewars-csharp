namespace RomanNumeralsHelper;

/// <summary>
/// Fournit des méthodes utilitaires pour convertir
/// un entier en nombre romain et inversement.
/// </summary>
public static class RomanNumerals
{
    /// <summary>
    /// Table de correspondance ordonnée entre valeurs entières
    /// et symboles romains.
    /// </summary>
    private static readonly (int Value, string Symbol)[] RomanMap =
    [
        (1000, "M"),
        (900, "CM"),
        (500, "D"),
        (400, "CD"),
        (100, "C"),
        (90, "XC"),
        (50, "L"),
        (40, "XL"),
        (10, "X"),
        (9, "IX"),
        (5, "V"),
        (4, "IV"),
        (1, "I")
    ];

    /// <summary>
    /// Convertit un entier en nombre romain.
    /// </summary>
    /// <param name="n">Valeur entière à convertir.</param>
    /// <returns>La représentation romaine de la valeur.</returns>
    public static string ToRoman(int n)
    {
        if (n <= 0 || n >= 4000)
        {
            throw new System.ArgumentOutOfRangeException(nameof(n), "La valeur doit être comprise entre 1 et 3999.");
        }

        var result = new System.Text.StringBuilder();

        foreach (var (value, symbol) in RomanMap)
        {
            while (n >= value)
            {
                result.Append(symbol);
                n -= value;
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Convertit un nombre romain en entier.
    /// </summary>
    /// <param name="romanNumeral">Nombre romain à convertir.</param>
    /// <returns>La valeur entière correspondante.</returns>
    public static int FromRoman(string romanNumeral)
    {
        if (string.IsNullOrWhiteSpace(romanNumeral))
        {
            throw new System.ArgumentException("La valeur romaine ne peut pas être vide.", nameof(romanNumeral));
        }

        int index = 0;
        int result = 0;

        while (index < romanNumeral.Length)
        {
            foreach (var (value, symbol) in RomanMap)
            {
                if (MatchesAt(romanNumeral, symbol, index))
                {
                    result += value;
                    index += symbol.Length;
                    break;
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Convertit un chiffre romain en entier.
    /// </summary>
    /// <param name="romanNumeral">Chaîne représentant un nombre romain.</param>
    /// <returns>Valeur entière correspondante.</returns>
    /// <exception cref="ArgumentException">
    /// Levée si la chaîne est vide ou invalide.
    /// </exception>
    public static int FromRomanV2(string romanNumeral)
    {
        if (string.IsNullOrWhiteSpace(romanNumeral))
            throw new ArgumentException("Le nombre romain ne peut pas être vide.", nameof(romanNumeral));

        int index = 0;
        int result = 0;

        while (index < romanNumeral.Length)
        {
            foreach (var (value, symbol) in RomanMap)
            {
                if (romanNumeral.AsSpan(index).StartsWith(symbol))
                {
                    result += value;
                    index += symbol.Length;
                    break;
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Indique si un symbole romain correspond à une position donnée dans une chaîne.
    /// </summary>
    /// <param name="source">Chaîne source.</param>
    /// <param name="symbol">Symbole à rechercher.</param>
    /// <param name="startIndex">Position de départ.</param>
    /// <returns><c>true</c> si le symbole correspond ; sinon <c>false</c>.</returns>
    private static bool MatchesAt(string source, string symbol, int startIndex)
    {
        if (startIndex + symbol.Length > source.Length)
        {
            return false;
        }

        for (int i = 0; i < symbol.Length; i++)
        {
            if (source[startIndex + i] != symbol[i])
            {
                return false;
            }
        }

        return true;
    }
}