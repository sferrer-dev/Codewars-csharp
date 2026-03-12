namespace GreedIsGood;

/// <summary>
/// Fournit la solution du kata Greed is Good.
/// </summary>
public class Kata
{
    /// <summary>
    /// Calcule le score d'un lancer de cinq dés selon les règles du jeu Greed.
    /// </summary>
    /// <param name="dice">Tableau contenant les valeurs des dés.</param>
    /// <returns>Le score total du lancer.</returns>
    public static int Score(int[] dice)
    {
        ArgumentNullException.ThrowIfNull(dice);

        int[] occurrences = new int[7];

        foreach (int die in dice)
        {
            occurrences[die]++;
        }

        int score = 0;

        for (int value = 1; value <= 6; value++)
        {
            if (occurrences[value] >= 3)
            {
                score += value == 1 ? 1000 : value * 100;
                occurrences[value] -= 3;
            }
        }

        score += occurrences[1] * 100;
        score += occurrences[5] * 50;

        return score;
    }
}