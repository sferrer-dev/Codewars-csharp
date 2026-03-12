namespace ProdFib;

/// <summary>
/// Fournit une solution au kata Codewars
/// "Product of consecutive Fib numbers".
/// </summary>
/// <remarks>
/// L'objectif est de trouver deux nombres de Fibonacci consécutifs
/// F(n) et F(n+1) tels que :
///
/// F(n) * F(n+1) = prod
///
/// Si un tel couple existe, on retourne :
/// [F(n), F(n+1), 1]
///
/// Sinon on retourne le premier couple tel que
/// F(n) * F(n+1) > prod avec :
/// [F(n), F(n+1), 0]
/// </remarks>
public class ProdFib
{
    /// <summary>
    /// Recherche deux nombres de Fibonacci consécutifs
    /// dont le produit correspond (ou dépasse) la valeur demandée.
    /// </summary>
    /// <param name="prod">Produit cible.</param>
    /// <returns>
    /// Tableau contenant :
    /// <list type="bullet">
    /// <item>F(n)</item>
    /// <item>F(n+1)</item>
    /// <item>1 si le produit est exact, sinon 0</item>
    /// </list>
    /// </returns>
    public static ulong[] productFib(ulong prod)
    {
        // Les deux premiers nombres de Fibonacci
        ulong a = 0;
        ulong b = 1;

        // On continue tant que le produit est inférieur au produit cible
        while (a * b < prod)
        {
            ulong next = a + b;

            // Décalage de la fenêtre Fibonacci
            a = b;
            b = next;
        }

        // Vérifie si le produit est exact
        ulong isExact = (a * b == prod) ? 1UL : 0UL;

        return new ulong[] { a, b, isExact };
    }
}
