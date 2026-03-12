namespace HowGoodAreYouReally;

/// <summary>
/// Classe contenant la logique permettant de comparer une note avec la moyenne de la classe.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Détermine si la note de l'utilisateur est supérieure à la moyenne de la classe.
    /// </summary>
    /// <param name="classPoints">Un tableau contenant les notes des autres élèves de la classe.</param>
    /// <param name="yourPoints">La note de l'utilisateur à comparer.</param>
    /// <returns>True si la note de l'utilisateur est supérieure à la moyenne de la classe, sinon False.</returns>
    public static bool BetterThanAverageLiqn(int[] classPoints, int yourPoints)
    {
        double average = classPoints.Average();
        return yourPoints > average;
    }

    public static bool BetterThanAverage(int[] classPoints, int yourPoints)
    {
        if (classPoints == null || classPoints.Length == 0)
            return true; // Cas limite : pas de classe, donc supérieur par défaut

        int total = 0;
        for (int i = 0; i < classPoints.Length; i++)
        {
            total += classPoints[i];
        }

        double average = (double)total / classPoints.Length;

        return yourPoints > average;
    }
}
