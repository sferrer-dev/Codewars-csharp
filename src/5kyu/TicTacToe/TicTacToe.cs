namespace TicTacToe;

/// <summary>
/// Fournit une logique permettant de déterminer l'état d'une partie
/// de Tic-Tac-Toe (morpion) à partir d'un plateau 3x3.
/// </summary>
public class TicTacToe
{
    /// <summary>
    /// Analyse l'état du plateau et détermine si un joueur a gagné,
    /// si la partie est nulle ou si elle n'est pas encore terminée.
    /// </summary>
    /// <param name="board">
    /// Plateau de jeu 3x3 où :
    /// 0 = case vide,
    /// 1 = joueur X,
    /// 2 = joueur O.
    /// </param>
    /// <returns>
    /// 1 si X a gagné,
    /// 2 si O a gagné,
    /// 0 si la partie est nulle,
    /// -1 si la partie n'est pas terminée.
    /// </returns>
    public int IsSolved(int[,] board)
    {
        // Vérification des lignes
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] != 0 &&
                board[row, 0] == board[row, 1] &&
                board[row, 1] == board[row, 2])
            {
                return board[row, 0];
            }
        }

        // Vérification des colonnes
        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] != 0 &&
                board[0, col] == board[1, col] &&
                board[1, col] == board[2, col])
            {
                return board[0, col];
            }
        }

        // Vérification diagonale principale
        if (board[0, 0] != 0 &&
            board[0, 0] == board[1, 1] &&
            board[1, 1] == board[2, 2])
        {
            return board[0, 0];
        }

        // Vérification diagonale secondaire
        if (board[0, 2] != 0 &&
            board[0, 2] == board[1, 1] &&
            board[1, 1] == board[2, 0])
        {
            return board[0, 2];
        }

        // Vérification s'il reste des cases vides
        foreach (int cell in board)
        {
            if (cell == 0)
            {
                return -1;
            }
        }

        // Sinon c'est un match nul
        return 0;
    }

    /// <summary>
    /// Détermine l'état courant de la partie.
    /// </summary>
    /// <param name="board">
    /// Plateau 3x3 où 0 représente une case vide,
    /// 1 le joueur X et 2 le joueur O.
    /// </param>
    /// <returns>
    /// 1 si X a gagné,
    /// 2 si O a gagné,
    /// 0 si la partie est nulle,
    /// -1 si la partie n'est pas terminée.
    /// </returns>
    public int IsSolvedLinq(int[,] board)
    {
        int[][] lines =
        [
            [board[0, 0], board[0, 1], board[0, 2]],
            [board[1, 0], board[1, 1], board[1, 2]],
            [board[2, 0], board[2, 1], board[2, 2]],
            [board[0, 0], board[1, 0], board[2, 0]],
            [board[0, 1], board[1, 1], board[2, 1]],
            [board[0, 2], board[1, 2], board[2, 2]],
            [board[0, 0], board[1, 1], board[2, 2]],
            [board[0, 2], board[1, 1], board[2, 0]]
        ];

        int winner = lines
            .Where(line => line[0] != 0 && line.All(cell => cell == line[0]))
            .Select(line => line[0])
            .FirstOrDefault();

        return winner != 0
            ? winner
            : board.Cast<int>().Any(cell => cell == 0) ? -1 : 0;
    }

}
