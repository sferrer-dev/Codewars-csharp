namespace MakeSpiral;

/// <summary>
/// Fournit une méthode de génération d'une spirale binaire carrée.
/// </summary>
public class Spiralizor
{
    /// <summary>
    /// Génère une matrice carrée contenant une spirale de <c>1</c> et de <c>0</c>.
    /// </summary>
    /// <param name="size">Taille de la matrice carrée à générer.</param>
    /// <returns>
    /// Une matrice <c>size x size</c> contenant la spirale.
    /// Les <c>1</c> représentent le tracé, les <c>0</c> représentent le vide.
    /// </returns>
    public static int[,] Spiralize(int size)
    {
        // Création de la matrice carrée qui contiendra la spirale.
        // Par défaut, toutes les cases valent 0.
        int[,] spiral = new int[size, size];

        // Vecteurs de déplacement pour parcourir la grille.
        // L'ordre correspond à : droite, bas, gauche, haut.
        int[] rowDirections = [0, 1, 0, -1];
        int[] columnDirections = [1, 0, -1, 0];

        // Position courante dans la grille.
        // On commence dans le coin supérieur gauche.
        int row = 0;
        int column = 0;

        // Index de direction courant (0 = droite au départ).
        int directionIndex = 0;

        // Boucle principale : on continue tant que l'on peut avancer.
        while (true)
        {
            // On marque la position courante comme faisant partie de la spirale.
            spiral[row, column] = 1;

            // On vérifie si on peut continuer dans la même direction.
            if (CanMove(spiral, row, column, directionIndex, rowDirections, columnDirections))
            {
                // Si c'est possible, on avance d'une case.
                row += rowDirections[directionIndex];
                column += columnDirections[directionIndex];
                continue;
            }

            // Sinon, on tourne à droite (direction suivante).
            // Le modulo permet de boucler sur les 4 directions.
            directionIndex = (directionIndex + 1) % 4;

            // Après rotation, on teste si le déplacement devient possible.
            if (CanMove(spiral, row, column, directionIndex, rowDirections, columnDirections))
            {
                row += rowDirections[directionIndex];
                column += columnDirections[directionIndex];
                continue;
            }

            // Si même après rotation on ne peut pas avancer,
            // cela signifie que la spirale est terminée.
            break;
        }

        return spiral;
    }

    /// <summary>
    /// Indique si l'on peut avancer d'une case dans la direction courante
    /// sans sortir de la grille, sans écraser un <c>1</c> existant, et sans
    /// faire se toucher la spirale.
    /// </summary>
    private static bool CanMove(
        int[,] spiral,
        int row,
        int column,
        int directionIndex,
        int[] rowDirections,
        int[] columnDirections)
    {
        // Taille de la matrice carrée.
        int size = spiral.GetLength(0);

        // Calcul de la prochaine case si l'on avance.
        int nextRow = row + rowDirections[directionIndex];
        int nextColumn = column + columnDirections[directionIndex];

        // 1) Vérifier que la case cible est toujours dans la grille.
        if (!IsInside(nextRow, nextColumn, size))
        {
            return false;
        }

        // 2) Vérifier que la case n'est pas déjà occupée par la spirale.
        if (spiral[nextRow, nextColumn] == 1)
        {
            return false;
        }

        // Pour respecter la règle du kata :
        // "la spirale ne doit jamais se toucher".
        //
        // On inspecte les voisins orthogonaux de la case cible.
        // Si un voisin contient déjà 1, cela créerait un contact
        // avec une autre branche de la spirale.
        int[] neighborRows = [-1, 1, 0, 0];
        int[] neighborColumns = [0, 0, -1, 1];

        for (int i = 0; i < 4; i++)
        {
            int neighborRow = nextRow + neighborRows[i];
            int neighborColumn = nextColumn + neighborColumns[i];

            // Si le voisin sort de la grille, on l'ignore.
            if (!IsInside(neighborRow, neighborColumn, size))
            {
                continue;
            }

            // La case d'où l'on vient fait naturellement partie de la spirale,
            // donc ce contact est normal et doit être ignoré.
            if (neighborRow == row && neighborColumn == column)
            {
                continue;
            }

            // Si un autre voisin contient déjà 1,
            // avancer ici ferait toucher la spirale à elle-même.
            if (spiral[neighborRow, neighborColumn] == 1)
            {
                return false;
            }
        }

        // Si toutes les vérifications sont validées,
        // le déplacement est autorisé.
        return true;
    }

    /// <summary>
    /// Vérifie si une position appartient à la grille.
    /// </summary>
    private static bool IsInside(int row, int column, int size)
    {
        // Une position est valide si elle se situe dans les bornes de la matrice.
        return row >= 0 && row < size && column >= 0 && column < size;
    }
}