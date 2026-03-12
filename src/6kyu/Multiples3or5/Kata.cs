namespace Multiples3or5;

/// <summary>
/// Fournit une méthode permettant de calculer la somme
/// des multiples de 3 ou de 5 strictement inférieurs
/// à un nombre donné.
/// </summary>
public class Kata
{
    /// <summary>
    /// Calcule la somme de tous les nombres naturels strictement inférieurs
    /// à <paramref name="number"/> qui sont des multiples de 3 ou de 5.
    /// </summary>
    /// <param name="number">
    /// Nombre entier de référence.  
    /// Si la valeur est négative ou nulle, la méthode retourne 0.
    /// </param>
    /// <returns>
    /// La somme des multiples de 3 ou 5 strictement inférieurs à <paramref name="number"/>.
    /// </returns>
    public static int Solution(int number)
    {
        // Garde-fou : aucun multiple possible pour une valeur négative ou nulle
        if (number <= 0)
        {
            return 0;
        }

        var sum = 0;

        for (var i = 0; i < number; i++)
        {
            if (IsMultipleOfThreeOrFive(i))
            {
                sum += i;
            }
        }

        return sum;
    }

    /// <summary>
    /// Détermine si un nombre est un multiple de 3 ou de 5.
    /// </summary>
    /// <param name="value">Nombre à évaluer.</param>
    /// <returns>
    /// <c>true</c> si le nombre est divisible par 3 ou par 5 ; sinon <c>false</c>.
    /// </returns>
    private static bool IsMultipleOfThreeOrFive(int value)
        => value % 3 == 0 || value % 5 == 0;
}
