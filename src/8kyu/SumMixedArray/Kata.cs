namespace SumMixedArray;

/// <summary>
/// Fournit une méthode utilitaire pour additionner un tableau mixte d'entiers et de chaînes représentant des entiers.
/// </summary>
public class Kata
{
    /// <summary>
    /// Expression lambda pour calculer la somme des éléments d'un tableau d'objets où chaque élément est soit un entier, soit une chaîne représentant un entier.
    /// </summary>
    /// <param name="x">Tableau d'objets contenant des entiers ou des chaînes représentant des entiers.</param>
    /// <returns>La somme des valeurs converties en entiers.</returns>
    public static int SumMixLinq(object[] x)
    {
        return x.Sum(item => Convert.ToInt32(item));
    }
    /// <summary>
    /// Calcule la somme des éléments d'un tableau d'objets où chaque élément est soit un entier, soit une chaîne représentant un entier.
    /// </summary>
    /// <param name="x">Tableau d'objets contenant des entiers ou des chaînes représentant des entiers.</param>
    /// <returns>La somme des valeurs converties en entiers.</returns>
    public static int SumMix(object[] x)
    {
        int sum = 0;

        foreach (object item in x)
        {
            // Convertit chaque élément en entier et l'ajoute à la somme
            sum += Convert.ToInt32(item);
        }

        return sum;
    }

}
