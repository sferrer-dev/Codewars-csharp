namespace BitCounting;

/// <summary>
/// Fournit une implémentation du kata Codewars "Bit Counting".
/// L'objectif est de compter le nombre de bits à 1 dans la
/// représentation binaire d'un entier non négatif.
/// </summary>
public class Kata
{
    /// <summary>
    /// Compte le nombre de bits positionnés à 1 dans l'écriture
    /// binaire d'un entier.
    /// </summary>
    /// <param name="n">
    /// Entier non négatif dont on souhaite analyser la représentation binaire.
    /// </param>
    /// <returns>
    /// Nombre de bits à 1 dans la représentation binaire de <paramref name="n"/>.
    /// </returns>
    public static int CountBits(int n)
    {
        int count = 0;

        // Tant qu'il reste des bits à analyser
        while (n > 0)
        {
            /*
             * L'opération (n & 1) permet d'isoler le bit de poids faible.
             *
             * Exemple :
             * n = 13  → 1101
             * n & 1   → 0001 = 1
             *
             * Si le bit vaut 1, on incrémente le compteur.
             */
            count += n & 1;

            /*
             * Décalage binaire vers la droite.
             * Cela revient à "supprimer" le bit de droite déjà analysé.
             *
             * Exemple :
             * 1101 >> 1 → 0110
             */
            n >>= 1;
        }

        return count;
    }
}