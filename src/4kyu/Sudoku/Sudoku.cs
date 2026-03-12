namespace Sudoku;

/// <summary>
/// Représente une grille de Sudoku de taille N x N
/// et fournit une méthode de validation complète.
/// </summary>
public class Sudoku
{
    private readonly int[][] _sudokuData;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="Sudoku"/>.
    /// </summary>
    /// <param name="sudokuData">Grille de Sudoku à valider.</param>
    public Sudoku(int[][] sudokuData)
    {
        _sudokuData = sudokuData;
    }

    /// <summary>
    /// Vérifie si la grille représente un Sudoku valide.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> si la structure et le contenu de la grille sont valides ;
    /// sinon, <see langword="false"/>.
    /// </returns>
    public bool IsValid()
    {
        // Une grille nulle ou vide ne peut pas représenter un Sudoku valide.
        if (_sudokuData is null || _sudokuData.Length == 0)
        {
            return false;
        }

        int size = _sudokuData.Length;

        // Un Sudoku N x N doit avoir une racine carrée entière
        // pour pouvoir être découpé en sous-grilles régulières.
        int regionSize = (int)Math.Sqrt(size);
        if (regionSize * regionSize != size)
        {
            return false;
        }

        // Vérifie que chaque ligne existe bien et contient exactement N colonnes.
        for (int row = 0; row < size; row++)
        {
            if (_sudokuData[row] is null || _sudokuData[row].Length != size)
            {
                return false;
            }
        }

        // Validation des lignes :
        // chaque ligne doit contenir exactement une fois chaque valeur de 1 à N.
        for (int row = 0; row < size; row++)
        {
            if (!IsValidGroup(_sudokuData[row], size))
            {
                return false;
            }
        }

        // Validation des colonnes :
        // on reconstruit chaque colonne dans un tableau temporaire,
        // puis on applique la même règle que pour une ligne.
        for (int column = 0; column < size; column++)
        {
            int[] values = new int[size];

            for (int row = 0; row < size; row++)
            {
                values[row] = _sudokuData[row][column];
            }

            if (!IsValidGroup(values, size))
            {
                return false;
            }
        }

        // Validation des sous-grilles.
        // Exemple :
        // - pour un Sudoku 9x9, regionSize = 3, donc sous-grilles 3x3
        // - pour un Sudoku 4x4, regionSize = 2, donc sous-grilles 2x2
        for (int startRow = 0; startRow < size; startRow += regionSize)
        {
            for (int startColumn = 0; startColumn < size; startColumn += regionSize)
            {
                int[] values = new int[size];
                int index = 0;

                for (int row = startRow; row < startRow + regionSize; row++)
                {
                    for (int column = startColumn; column < startColumn + regionSize; column++)
                    {
                        values[index++] = _sudokuData[row][column];
                    }
                }

                if (!IsValidGroup(values, size))
                {
                    return false;
                }
            }
        }

        return true;
    }

    /// <summary>
    /// Vérifie qu'un groupe de valeurs (ligne, colonne ou sous-grille)
    /// contient exactement une fois chaque entier de 1 à N.
    /// </summary>
    /// <param name="values">Valeurs du groupe à vérifier.</param>
    /// <param name="size">Taille attendue du groupe.</param>
    /// <returns>
    /// <see langword="true"/> si le groupe est valide ; sinon, <see langword="false"/>.
    /// </returns>
    private static bool IsValidGroup(int[] values, int size)
    {
        // Tableau de présence :
        // seen[x] indique si la valeur x a déjà été rencontrée.
        bool[] seen = new bool[size + 1];

        foreach (int value in values)
        {
            // Les valeurs valides doivent être dans l'intervalle [1..N].
            if (value < 1 || value > size)
            {
                return false;
            }

            // Si la valeur a déjà été vue, il y a un doublon.
            if (seen[value])
            {
                return false;
            }

            seen[value] = true;
        }

        return true;
    }
}
