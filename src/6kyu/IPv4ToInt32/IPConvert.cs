namespace IPv4ToInt32;


/// <summary>
/// Fournit une méthode permettant de convertir
/// une adresse IPv4 en entier non signé 32 bits.
/// </summary>
public class IPConvert
{
    /// <summary>
    /// Convertit une adresse IPv4 (notation décimale pointée)
    /// en un entier non signé 32 bits.
    /// </summary>
    /// <param name="ip">Adresse IPv4 au format "a.b.c.d".</param>
    /// <returns>Valeur numérique équivalente sur 32 bits.</returns>
    public static uint ToInt32(string ip)
    {
        /*
         * Une adresse IPv4 est composée de 4 octets séparés par des points.
         * Exemple :
         * "128.32.10.1"
         */
        string[] parts = ip.Split('.');

        uint result = 0;

        /*
         * On traite chaque octet dans l'ordre.
         * Chaque octet est placé dans la position correspondante
         * grâce à un décalage binaire.
         */
        for (int i = 0; i < 4; i++)
        {
            uint value = uint.Parse(parts[i]);

            /*
             * Décalage binaire vers la gauche.
             *
             * Octet 0 → position 24 bits
             * Octet 1 → position 16 bits
             * Octet 2 → position 8 bits
             * Octet 3 → position 0 bit
             */
            result |= value << (24 - (8 * i));
        }

        return result;
    }
}