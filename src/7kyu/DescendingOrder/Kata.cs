namespace DescendingOrder;

/// <summary>
/// Fournit une fonction permettant de réorganiser les chiffres
/// d'un entier non négatif dans l'ordre décroissant.
/// </summary>
public static class Kata
{

    /// <summary>
    /// Réorganise les chiffres d'un nombre entier non négatif
    /// pour former le plus grand nombre possible.
    /// </summary>
    /// <param name="num">Nombre à traiter.</param>
    /// <returns>
    /// Un entier composé des mêmes chiffres que <paramref name="num"/>,
    /// triés dans l'ordre décroissant.
    /// </returns>
    public static int DescendingOrder(int num)
    {
        // Cas trivial : si le nombre vaut 0, le résultat vaut aussi 0.
        if (num == 0)
        {
            return 0;
        }

        // Tableau de comptage :
        // l'indice représente le chiffre (0 à 9),
        // la valeur représente le nombre d'occurrences de ce chiffre.
        int[] digitCounts = new int[10];

        // On extrait chaque chiffre du nombre avec les opérations
        // modulo (%) et division entière (/).
        while (num > 0)
        {
            int digit = num % 10;   // Récupère le dernier chiffre.
            digitCounts[digit]++;   // Incrémente son compteur.
            num /= 10;              // Supprime le dernier chiffre.
        }

        int result = 0;

        // On reconstruit ensuite le nombre final
        // en parcourant les chiffres du plus grand au plus petit.
        for (int digit = 9; digit >= 0; digit--)
        {
            // Tant qu'il reste des occurrences de ce chiffre,
            // on l'ajoute à droite du résultat.
            while (digitCounts[digit] > 0)
            {
                result = (result * 10) + digit;
                digitCounts[digit]--;
            }
        }

        return result;
    }
    /// <summary>
    /// Réorganise les chiffres d'un nombre entier dans l'ordre décroissant
    /// afin de produire le plus grand nombre possible.
    /// </summary>
    /// <param name="num">
    /// Entier non négatif dont les chiffres doivent être triés.
    /// </param>
    /// <returns>
    /// Un nouvel entier constitué des mêmes chiffres triés
    /// du plus grand au plus petit.
    /// </returns>
    public static int DescendingOrderLinq(int num)
    {
        // Conversion du nombre en chaîne de caractères
        // afin de manipuler chaque chiffre individuellement.
        string digits = num.ToString();

        // Tri des caractères (chiffres) dans l'ordre décroissant.
        // OrderByDescending applique un tri LINQ.
        var sortedDigits = digits
            .OrderByDescending(c => c);

        // Reconstruction d'une nouvelle chaîne à partir des chiffres triés.
        string resultString = new(sortedDigits.ToArray());

        // Conversion finale en entier.
        return int.Parse(resultString);
    }
}