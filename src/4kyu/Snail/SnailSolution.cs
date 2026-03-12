namespace Snail;

/// <summary>
/// Fournit une implémentation du parcours en spirale horaire
/// d'une matrice carrée.
/// </summary>
public static class SnailSolution
{
    /// <summary>
    /// Parcourt une matrice carrée dans l'ordre "snail"
    /// (spirale dans le sens des aiguilles d'une montre)
    /// et retourne les éléments dans l'ordre rencontré.
    /// </summary>
    /// <param name="array">Matrice carrée à parcourir.</param>
    /// <returns>Tableau contenant les éléments parcourus en spirale.</returns>
    public static int[] Snail(int[][] array)
    {
        // ---------------------------------------------------------
        // Gestion des cas limites
        // ---------------------------------------------------------
        // Si la matrice est vide ou si la première ligne est vide,
        // il n'y a aucun élément à parcourir.
        if (array.Length == 0 || array[0].Length == 0)
        {
            return [];
        }

        // Taille de la matrice carrée (n x n)
        int size = array.Length;

        // Tableau résultat contenant les éléments dans l'ordre snail
        int[] result = new int[size * size];

        // Index de position dans le tableau résultat
        int index = 0;

        // ---------------------------------------------------------
        // Définition des bornes de la spirale
        // ---------------------------------------------------------
        // Ces variables définissent le "rectangle courant"
        // que l'on parcourt avant de se déplacer vers l'intérieur.

        // Ligne supérieure de la zone à parcourir
        int top = 0;

        // Ligne inférieure
        int bottom = size - 1;

        // Colonne gauche
        int left = 0;

        // Colonne droite
        int right = size - 1;

        // ---------------------------------------------------------
        // Boucle principale
        // ---------------------------------------------------------
        // On continue tant que les bornes ne se croisent pas.
        // Chaque itération parcourt une "couche" de la spirale.
        while (top <= bottom && left <= right)
        {
            // -----------------------------------------------------
            // 1. Parcours de la ligne supérieure (gauche → droite)
            // -----------------------------------------------------
            for (int column = left; column <= right; column++)
            {
                result[index++] = array[top][column];
            }

            // La ligne supérieure vient d'être parcourue,
            // on descend donc la borne supérieure.
            top++;

            // -----------------------------------------------------
            // 2. Parcours de la colonne droite (haut → bas)
            // -----------------------------------------------------
            for (int row = top; row <= bottom; row++)
            {
                result[index++] = array[row][right];
            }

            // La colonne droite est parcourue,
            // on décale la borne droite vers la gauche.
            right--;

            // -----------------------------------------------------
            // 3. Parcours de la ligne inférieure (droite → gauche)
            // -----------------------------------------------------
            // Ce test évite de parcourir deux fois la même ligne
            // dans les matrices de petite taille.
            if (top <= bottom)
            {
                for (int column = right; column >= left; column--)
                {
                    result[index++] = array[bottom][column];
                }

                // La ligne inférieure est parcourue,
                // on remonte la borne inférieure.
                bottom--;
            }

            // -----------------------------------------------------
            // 4. Parcours de la colonne gauche (bas → haut)
            // -----------------------------------------------------
            // Ce test évite de parcourir deux fois la même colonne
            // lorsque la spirale se referme.
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                {
                    result[index++] = array[row][left];
                }

                // La colonne gauche est parcourue,
                // on décale la borne gauche vers la droite.
                left++;
            }
        }

        // ---------------------------------------------------------
        // Résultat final
        // ---------------------------------------------------------
        return result;
    }
}