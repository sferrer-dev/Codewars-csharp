namespace Grasshopper;

/// <summary>
/// Fournit des méthodes utilitaires pour le kata Grasshopper – Summation.
/// </summary>
public class Kata
{
    /// <summary>
    /// Calcule la somme de tous les nombres entiers compris entre 1 et <paramref name="num"/> inclus
    /// en utilisant plusieurs approches (boucle <c>for</c>, boucle <c>while</c>,
    /// formule mathématique et LINQ) afin de garantir la cohérence du résultat.
    /// </summary>
    /// <param name="num">Nombre entier strictement positif.</param>
    /// <returns>
    /// La somme des entiers de 1 à <paramref name="num"/> si toutes les implémentations
    /// retournent le même résultat.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Levée lorsque les différentes implémentations produisent des résultats incohérents.
    /// </exception>
    public static int summation(int num)
    {
        // Implémentation 1 : boucle for
        int total1 = 0;
        for (int i = 1; i <= num; i++)
        {
            total1 += i;
        }

        // Implémentation 2 : boucle while
        int total2 = 0;
        int compteur = 1;
        while (compteur <= num)
        {
            total2 += compteur;
            compteur++;
        }

        // Implémentation 3 : formule mathématique (Gauss)
        int total3 = num * (num + 1) / 2;

        // Implémentation 4 : LINQ
        int total4 = Enumerable.Range(1, num).Sum();

        // Vérification de la cohérence des résultats
        if (total1 != total2 || total1 != total3 || total1 != total4)
        {
            throw new InvalidOperationException(
                $"Incohérence détectée dans le calcul de la sommation pour num = {num}. " +
                $"Résultats obtenus : for={total1}, while={total2}, formule={total3}, linq={total4}."
            );
        }

        // Retourne le résultat validé
        return total1;
    }
}
