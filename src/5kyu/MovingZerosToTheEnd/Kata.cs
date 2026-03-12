namespace MovingZerosToTheEnd;

public class Kata
{
    /// <summary>
    /// Déplace tous les zéros d'un tableau à la fin,
    /// en conservant l'ordre des autres éléments.
    /// </summary>
    /// <param name="arr">Tableau d'entiers en entrée.</param>
    /// <returns>
    /// Un nouveau tableau avec les zéros regroupés à la fin.
    /// </returns>
    public static int[] MoveZeroes(int[] arr)
    {
        // Liste de sortie.
        // On pré-alloue la capacité pour éviter des reallocations internes.
        var result = new List<int>(arr.Length);

        // Compteur de zéros rencontrés dans le tableau
        int zeroCount = 0;

        // Parcours du tableau dans l'ordre naturel (gauche → droite)
        foreach (var value in arr)
        {
            // Si l'élément est un zéro, on incrémente simplement le compteur
            if (value == 0)
            {
                zeroCount++;
            }
            else
            {
                // Sinon, on ajoute l'élément à la liste résultat
                // L'ordre relatif est automatiquement conservé
                result.Add(value);
            }
        }

        // Une fois tous les éléments non nuls ajoutés,
        // on ajoute les zéros à la fin de la liste
        for (int i = 0; i < zeroCount; i++)
        {
            result.Add(0);
        }

        // Conversion de la liste en tableau pour respecter la signature
        return result.ToArray();
    }
}
