namespace IsDivisibleBy;
/// <summary>
/// Fournit des méthodes utilitaires pour vérifier la divisibilité d'un nombre.
/// </summary>
public static class DivisibleNb
{
    /// <summary>
    /// Indique si le nombre <paramref name="n"/> est divisible à la fois par
    /// <paramref name="x"/> et <paramref name="y"/>.
    /// </summary>
    /// <param name="n">Nombre à tester.</param>
    /// <param name="x">Premier diviseur.</param>
    /// <param name="y">Second diviseur.</param>
    /// <returns>
    /// <c>true</c> si <paramref name="n"/> est divisible par <paramref name="x"/>
    /// et <paramref name="y"/> ; sinon <c>false</c>.
    /// </returns>
    public static bool IsDivisible(int n, int x, int y)
        => n % x == 0 && n % y == 0;
}
