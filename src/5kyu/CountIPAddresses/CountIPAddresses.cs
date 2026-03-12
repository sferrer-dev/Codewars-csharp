namespace CountIPAddresses;

/// <summary>
/// Fournit une implémentation permettant de calculer le nombre
/// d'adresses IPv4 situées entre deux adresses données.
/// </summary>
/// <remarks>
/// Le calcul inclut la première adresse et exclut la dernière.
/// L'idée consiste à convertir une adresse IPv4 en un entier
/// non signé sur 32 bits, puis à calculer la différence entre
/// les deux valeurs numériques.
/// </remarks>
public class CountIPAddresses
{
    /// <summary>
    /// Calcule le nombre d'adresses IPv4 comprises entre deux adresses.
    /// </summary>
    /// <param name="start">Adresse IPv4 de départ (incluse).</param>
    /// <param name="end">Adresse IPv4 de fin (exclue).</param>
    /// <returns>
    /// Nombre d'adresses situées entre <paramref name="start"/> et <paramref name="end"/>.
    /// </returns>
    public static long IpsBetween(string start, string end)
    {
        // Conversion des deux adresses IPv4 en valeurs numériques
        long startValue = IpToLong(start);
        long endValue = IpToLong(end);

        // La différence représente directement le nombre d'adresses
        // entre les deux valeurs.
        return endValue - startValue;
    }

    /// <summary>
    /// Convertit une adresse IPv4 (ex: "192.168.1.10")
    /// en sa représentation numérique sur 32 bits.
    /// </summary>
    /// <param name="ip">Adresse IPv4 au format texte.</param>
    /// <returns>Valeur numérique équivalente.</returns>
    /// <remarks>
    /// Une adresse IPv4 est composée de 4 octets :
    /// 
    ///     a.b.c.d
    ///
    /// Chaque octet représente une puissance de 256 :
    ///
    ///     a × 256³ + b × 256² + c × 256¹ + d × 256⁰
    ///
    /// On peut donc reconstruire l'entier en accumulant
    /// les valeurs successivement.
    /// </remarks>
    private static long IpToLong(string ip)
    {
        // Découpe l'adresse en ses 4 parties
        string[] octets = ip.Split('.');

        long result = 0;

        // On reconstruit progressivement la valeur numérique
        foreach (string octet in octets)
        {
            // Décalage d'un octet (équivalent à multiplier par 256)
            result = result * 256 + int.Parse(octet);
        }

        return result;
    }
}