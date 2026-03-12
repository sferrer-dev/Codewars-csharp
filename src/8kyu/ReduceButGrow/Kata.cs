namespace ReduceButGrow;

/// <summary>
/// Classe contenant des méthodes utilitaires pour la manipulation de tableaux d'entiers.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Calcule le produit de tous les éléments d'un tableau d'entiers.
    /// </summary>
    /// <param name="numbers">Le tableau d'entiers dont on souhaite calculer le produit.</param>
    /// <returns>Le produit de tous les éléments du tableau.</returns>
    /// <exception cref="ArgumentNullException">Lancé si le tableau fourni est null.</exception>
    public static int Grow(int[] numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers), "Le tableau ne peut pas être null.");

        var product = 1;

        foreach (var number in numbers)
        {
            product *= number;
        }

        return product;
    }

    /// <summary>
    /// Calcule le produit de tous les éléments d'un tableau d'entiers en utilisant LINQ.
    /// </summary>
    /// <param name="numbers">Le tableau d'entiers dont on souhaite calculer le produit.</param>
    /// <returns>Le produit de tous les éléments du tableau.</returns>
    /// <exception cref="ArgumentNullException">Lancé si le tableau fourni est null.</exception>
    public static int GrowLinq(int[] numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers), "Le tableau ne peut pas être null.");

        return numbers.Aggregate(1, (acc, val) => acc * val);
    }
}