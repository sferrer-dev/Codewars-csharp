namespace BinaryAddition;

/// <summary>
/// Fournit des opérations liées à l'addition binaire.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Additionne deux entiers et retourne leur somme sous forme
    /// d'une chaîne représentant le nombre en binaire.
    /// </summary>
    /// <param name="a">Premier entier en base décimale.</param>
    /// <param name="b">Second entier en base décimale.</param>
    /// <returns>
    /// Une chaîne contenant la représentation binaire de la somme.
    /// </returns>
    public static string AddBinary(int a, int b)
    {
        // Étape 1 : addition classique en base décimale
        int sum = a + b;

        // Étape 2 : conversion du résultat décimal vers une chaîne binaire
        // Convert.ToString(value, base) permet de convertir un entier
        // vers une représentation dans une base donnée (ici base 2).
        string binary = Convert.ToString(sum, 2);

        // Étape 3 : retourner la chaîne binaire obtenue
        return binary;
    }

    /// <summary>
    /// Additionne deux entiers et retourne leur somme sous forme
    /// d'une chaîne représentant le nombre en binaire.
    /// 
    /// Cette implémentation réalise la conversion décimal → binaire
    /// manuellement en utilisant l'algorithme classique des divisions
    /// successives par 2.
    /// </summary>
    /// <param name="a">Premier entier.</param>
    /// <param name="b">Second entier.</param>
    /// <returns>Représentation binaire de la somme.</returns>
    public static string AddBinaryConversion(int a, int b)
    {
        // Étape 1 : addition en base décimale
        int sum = a + b;

        // Cas particulier : si la somme vaut 0
        if (sum == 0)
        {
            return "0";
        }

        string result = string.Empty;

        // Étape 2 : conversion décimal → binaire
        // Principe :
        // - on divise le nombre par 2
        // - le reste (0 ou 1) constitue le bit courant
        // - on continue jusqu'à ce que le quotient devienne 0
        while (sum > 0)
        {
            int remainder = sum % 2;   // récupère le bit courant

            // On ajoute le bit au début de la chaîne
            // car les bits sont obtenus de droite à gauche
            result = remainder + result;

            // division entière par 2 pour passer au bit suivant
            sum /= 2;
        }

        return result;
    }

    /// <summary>
    /// Additionne deux entiers et retourne leur représentation binaire.
    /// 
    /// Cette implémentation utilise des opérateurs bitwise :
    /// - '&' pour extraire le bit de poids faible
    /// - '>>' pour décaler les bits vers la droite
    /// </summary>
    /// <param name="a">Premier entier.</param>
    /// <param name="b">Second entier.</param>
    /// <returns>Chaîne représentant la somme en binaire.</returns>
    public static string AddBinaryBitwise(int a, int b)
    {
        // Étape 1 : addition classique
        int sum = a + b;

        // Cas particulier : si le résultat est 0
        if (sum == 0)
        {
            return "0";
        }

        string result = string.Empty;

        // Étape 2 : extraction des bits un par un
        while (sum > 0)
        {
            // Le bit de poids faible est obtenu avec un AND binaire
            // Exemple : 13 (1101) & 1 → 1
            int bit = sum & 1;

            // On ajoute le bit au début de la chaîne
            result = bit + result;

            // Décalage à droite : équivalent à une division entière par 2
            sum >>= 1;
        }

        return result;
    }

}