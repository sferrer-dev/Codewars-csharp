namespace SheepCounter;

/// <summary>
/// Fournit des méthodes utilitaires pour compter les moutons présents.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Compte le nombre de moutons présents dans une collection.
    /// </summary>
    /// <param name="sheep">
    /// Collection de valeurs booléennes :
    /// true = mouton présent,
    /// false = mouton absent,
    /// null = valeur invalide ignorée.
    /// </param>
    /// <returns>
    /// Nombre de moutons présents (true).
    /// </returns>
    public static int CountSheep(IEnumerable<bool?> sheep)
    {
        if (sheep is null)
        {
            return 0;
        }
        return sheep.Count(s => s == true);
    }

    /// <summary>
    /// Compte le nombre de moutons présents dans une collection
    /// sans utiliser LINQ.
    /// </summary>
    /// <param name="sheep">
    /// Collection de valeurs booléennes :
    /// true = mouton présent,
    /// false = mouton absent,
    /// null = valeur invalide ignorée.
    /// </param>
    /// <returns>
    /// Nombre de moutons présents (true).
    /// </returns>
    public static int CountSheepWithoutLinq(IEnumerable<bool?> sheep)
    {
        if (sheep is null)
        {
            return 0;
        }

        var count = 0;

        foreach (var value in sheep)
        {
            if (value == true)
            {
                count++;
            }
        }

        return count;
    }
}
