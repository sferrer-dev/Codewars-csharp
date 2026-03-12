namespace SortingByBits;

using System.Linq;

/// <summary>
/// Fournit une implémentation du kata Codewars "Sorting by bits".
/// Le tableau est trié selon :
/// 1) le nombre de bits à 1 dans l'écriture binaire de chaque nombre
/// 2) la valeur numérique en cas d'égalité.
/// </summary>
public class Kata
{
    /// <summary>
    /// Trie un tableau d'entiers selon le nombre de bits à 1
    /// présents dans leur représentation binaire.
    /// </summary>
    /// <param name="array">Tableau d'entiers à trier.</param>
    /// <returns>
    /// Un nouveau tableau trié selon :
    /// - le nombre de bits à 1
    /// - puis la valeur numérique.
    /// </returns>
    public static int[] SortByBit(int[] array)
    {
        return array
            /*
             * Premier critère de tri :
             * le nombre de bits à 1 dans chaque entier.
             */
            .OrderBy(CountBits)

            /*
             * Deuxième critère de tri :
             * la valeur de l'entier lui-même.
             */
            .ThenBy(x => x)

            /*
             * Conversion du résultat LINQ en tableau.
             */
            .ToArray();
    }

    /// <summary>
    /// Compte le nombre de bits à 1 dans la représentation
    /// binaire d'un entier.
    /// </summary>
    /// <param name="n">Entier à analyser.</param>
    /// <returns>Nombre de bits positionnés à 1.</returns>
    private static int CountBits(int n)
    {
        int count = 0;

        while (n > 0)
        {
            // Si le bit de poids faible vaut 1, on incrémente.
            count += n & 1;

            // Décalage à droite pour analyser le bit suivant.
            n >>= 1;
        }

        return count;
    }
}
