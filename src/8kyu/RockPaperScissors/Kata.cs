namespace RockPaperScissors;


/// <summary>
/// Classe contenant la logique du jeu Pierre-Papier-Ciseaux.
/// </summary>
public class Kata
{
    /// <summary>
    /// Détermine le gagnant d'une partie de pierre-papier-ciseaux entre deux joueurs.
    /// </summary>
    /// <param name="p1">Le choix du joueur 1 (rock, paper ou scissors).</param>
    /// <param name="p2">Le choix du joueur 2 (rock, paper ou scissors).</param>
    /// <returns>Un message indiquant quel joueur a gagné ou si c'est une égalité.</returns>
    public string Rps(string p1, string p2)
    {
        if (p1 == p2)
            return "Draw!";

        return (p1, p2) switch
        {
            ("rock", "scissors") => "Player 1 won!",
            ("scissors", "paper") => "Player 1 won!",
            ("paper", "rock") => "Player 1 won!",
            _ => "Player 2 won!"
        };
    }
}

