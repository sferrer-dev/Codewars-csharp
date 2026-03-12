namespace Snail;

/// <summary>
/// Fournit une implémentation du parcours en spirale horaire
/// d'une matrice carrée.
/// </summary>
public static class SnailClean
{
    /// <summary>
    /// Parcourt une matrice carrée dans l'ordre "snail"
    /// en partant du coin supérieur gauche vers le centre.
    /// </summary>
    /// <param name="array">Matrice carrée à parcourir.</param>
    /// <returns>
    /// Un tableau contenant les éléments de la matrice
    /// dans l'ordre du parcours en spirale.
    /// </returns>
    public static int[] Snail(int[][] array)
    {
        if (IsEmpty(array))
        {
            return [];
        }

        int size = array.Length;
        int[] result = new int[size * size];

        int index = 0;
        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;

        while (HasRemainingLayer(top, bottom, left, right))
        {
            TraverseTopRow(array, result, ref index, top, left, right);
            top++;

            TraverseRightColumn(array, result, ref index, right, top, bottom);
            right--;

            if (HasRemainingRows(top, bottom))
            {
                TraverseBottomRow(array, result, ref index, bottom, right, left);
                bottom--;
            }

            if (HasRemainingColumns(left, right))
            {
                TraverseLeftColumn(array, result, ref index, left, bottom, top);
                left++;
            }
        }

        return result;
    }

    /// <summary>
    /// Indique si la matrice est vide ou contient une première ligne vide.
    /// </summary>
    /// <param name="array">Matrice à vérifier.</param>
    /// <returns>
    /// <see langword="true"/> si la matrice ne contient aucun élément ;
    /// sinon <see langword="false"/>.
    /// </returns>
    private static bool IsEmpty(int[][] array)
    {
        return array.Length == 0 || array[0].Length == 0;
    }

    /// <summary>
    /// Indique s'il reste au moins une couche de spirale à parcourir.
    /// </summary>
    /// <param name="top">Borne supérieure courante.</param>
    /// <param name="bottom">Borne inférieure courante.</param>
    /// <param name="left">Borne gauche courante.</param>
    /// <param name="right">Borne droite courante.</param>
    /// <returns>
    /// <see langword="true"/> si les bornes définissent encore une zone valide ;
    /// sinon <see langword="false"/>.
    /// </returns>
    private static bool HasRemainingLayer(int top, int bottom, int left, int right)
    {
        return top <= bottom && left <= right;
    }

    /// <summary>
    /// Indique s'il reste encore au moins une ligne à parcourir.
    /// </summary>
    /// <param name="top">Borne supérieure courante.</param>
    /// <param name="bottom">Borne inférieure courante.</param>
    /// <returns>
    /// <see langword="true"/> s'il reste des lignes ; sinon <see langword="false"/>.
    /// </returns>
    private static bool HasRemainingRows(int top, int bottom)
    {
        return top <= bottom;
    }

    /// <summary>
    /// Indique s'il reste encore au moins une colonne à parcourir.
    /// </summary>
    /// <param name="left">Borne gauche courante.</param>
    /// <param name="right">Borne droite courante.</param>
    /// <returns>
    /// <see langword="true"/> s'il reste des colonnes ; sinon <see langword="false"/>.
    /// </returns>
    private static bool HasRemainingColumns(int left, int right)
    {
        return left <= right;
    }

    /// <summary>
    /// Parcourt la ligne supérieure de gauche à droite.
    /// </summary>
    /// <param name="array">Matrice source.</param>
    /// <param name="result">Tableau résultat.</param>
    /// <param name="index">Position courante d'écriture dans le résultat.</param>
    /// <param name="top">Indice de la ligne supérieure.</param>
    /// <param name="left">Indice de la colonne gauche.</param>
    /// <param name="right">Indice de la colonne droite.</param>
    private static void TraverseTopRow(
        int[][] array,
        int[] result,
        ref int index,
        int top,
        int left,
        int right)
    {
        for (int column = left; column <= right; column++)
        {
            result[index++] = array[top][column];
        }
    }

    /// <summary>
    /// Parcourt la colonne droite de haut en bas.
    /// </summary>
    /// <param name="array">Matrice source.</param>
    /// <param name="result">Tableau résultat.</param>
    /// <param name="index">Position courante d'écriture dans le résultat.</param>
    /// <param name="right">Indice de la colonne droite.</param>
    /// <param name="top">Indice de la ligne supérieure.</param>
    /// <param name="bottom">Indice de la ligne inférieure.</param>
    private static void TraverseRightColumn(
        int[][] array,
        int[] result,
        ref int index,
        int right,
        int top,
        int bottom)
    {
        for (int row = top; row <= bottom; row++)
        {
            result[index++] = array[row][right];
        }
    }

    /// <summary>
    /// Parcourt la ligne inférieure de droite à gauche.
    /// </summary>
    /// <param name="array">Matrice source.</param>
    /// <param name="result">Tableau résultat.</param>
    /// <param name="index">Position courante d'écriture dans le résultat.</param>
    /// <param name="bottom">Indice de la ligne inférieure.</param>
    /// <param name="right">Indice de la colonne droite.</param>
    /// <param name="left">Indice de la colonne gauche.</param>
    private static void TraverseBottomRow(
        int[][] array,
        int[] result,
        ref int index,
        int bottom,
        int right,
        int left)
    {
        for (int column = right; column >= left; column--)
        {
            result[index++] = array[bottom][column];
        }
    }

    /// <summary>
    /// Parcourt la colonne gauche de bas en haut.
    /// </summary>
    /// <param name="array">Matrice source.</param>
    /// <param name="result">Tableau résultat.</param>
    /// <param name="index">Position courante d'écriture dans le résultat.</param>
    /// <param name="left">Indice de la colonne gauche.</param>
    /// <param name="bottom">Indice de la ligne inférieure.</param>
    /// <param name="top">Indice de la ligne supérieure.</param>
    private static void TraverseLeftColumn(
        int[][] array,
        int[] result,
        ref int index,
        int left,
        int bottom,
        int top)
    {
        for (int row = bottom; row >= top; row--)
        {
            result[index++] = array[row][left];
        }
    }
}