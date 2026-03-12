namespace IsDivisibleBy;
public class KataChallenge
{
    public static bool IsDivisibleWithoutLink(int n, params int[] divisors)
    {
        foreach (var divisor in divisors)
        {
            if (n % divisor != 0)
                return false;
        }

        return true;
    }

    /// <summary>
    /// Indique si le nombre <paramref name="n"/> est divisible par l'ensemble
    /// des diviseurs fournis.
    /// </summary>
    /// <param name="n">Nombre à tester.</param>
    /// <param name="divisors">Liste des diviseurs.</param>
    /// <returns>
    /// <c>true</c> si <paramref name="n"/> est divisible par tous les diviseurs ;
    /// sinon <c>false</c>.
    /// </returns>
    public static bool IsDivisible(int n, params int[] divisors)
        => divisors.All(d => n % d == 0);
}
