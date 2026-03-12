namespace OppositesAttract;

/// <summary>
/// Contient la logique pour déterminer si deux personnes sont "amoureuses"
/// en fonction de la parité de leurs nombres respectifs de pétales.
/// </summary>
public static class LoveDetector
{
    /// <summary>
    /// Détermine si l'amour est réciproque en fonction de la parité des entiers donnés.
    /// L'amour est considéré vrai si l'un est pair et l'autre est impair.
    /// </summary>
    /// <param name="flower1">Nombre de pétales de la première fleur.</param>
    /// <param name="flower2">Nombre de pétales de la deuxième fleur.</param>
    /// <returns><c>true</c> si les entiers ont une parité opposée ; sinon <c>false</c>.</returns>
    public static bool lovefunc(int flower1, int flower2)
    {
        return (flower1 % 2) != (flower2 % 2);
    }
}
