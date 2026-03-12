namespace TheFeastOfManyBeasts;

/// <summary>
/// Classe contenant la méthode permettant de valider si un animal peut apporter un plat au festin.
/// </summary>
public class Kata
{
    /// <summary>
    /// Vérifie si le plat commence et se termine par les mêmes lettres que le nom de l'animal.
    /// </summary>
    /// <param name="beast">Nom de l'animal.</param>
    /// <param name="dish">Nom du plat apporté.</param>
    /// <returns>
    /// true si le plat est autorisé (même première et dernière lettre que le nom de l'animal), sinon false.
    /// </returns>
    public static bool FeastV2(string beast, string dish)
    {
        if (string.IsNullOrWhiteSpace(beast) || string.IsNullOrWhiteSpace(dish))
            return false;

        return beast[0] == dish[0] && beast[^1] == dish[^1];
    }

    /// <summary>
    /// Vérifie si le plat commence et se termine par les mêmes lettres que le nom de l'animal.
    /// </summary>
    /// <param name="beast">Nom de l'animal.</param>
    /// <param name="dish">Nom du plat apporté.</param>
    /// <returns>
    /// true si le plat est autorisé (même première et dernière lettre que le nom de l'animal), sinon false.
    /// </returns>
    public static bool Feast(string beast, string dish)
    {
        // Vérifier que les deux chaînes ne sont ni nulles ni vides
        if (string.IsNullOrWhiteSpace(beast) || string.IsNullOrWhiteSpace(dish))
        {
            return false;
        }

        // Extraire la première lettre du nom de l'animal
        char firstLetterOfBeast = beast[0];

        // Extraire la dernière lettre du nom de l'animal
        char lastLetterOfBeast = beast[beast.Length - 1];

        // Extraire la première lettre du plat
        char firstLetterOfDish = dish[0];

        // Extraire la dernière lettre du plat
        char lastLetterOfDish = dish[dish.Length - 1];

        // Comparer les premières et les dernières lettres respectivement
        bool sameFirstLetter = firstLetterOfBeast == firstLetterOfDish;
        bool sameLastLetter = lastLetterOfBeast == lastLetterOfDish;

        // Retourner vrai si les deux comparaisons sont vraies
        if (sameFirstLetter && sameLastLetter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
