namespace AlphabetPosition;

/// <summary>
/// Fournit une méthode permettant de convertir les lettres d'une chaîne
/// en leurs positions respectives dans l'alphabet.
/// 
/// Exemple :
/// a -> 1
/// b -> 2
/// c -> 3
/// ...
/// z -> 26
/// 
/// Les caractères non alphabétiques (espaces, ponctuation, chiffres)
/// sont ignorés.
/// </summary>
public class Kata
{
    /// <summary>
    /// Convertit chaque lettre du texte en sa position dans l'alphabet.
    /// </summary>
    /// <param name="text">
    /// Chaîne de caractères pouvant contenir lettres, espaces et ponctuation.
    /// </param>
    /// <returns>
    /// Une chaîne contenant les positions alphabétiques séparées par des espaces.
    /// </returns>
    public static string AlphabetPosition(string text)
    {
        // Liste qui contiendra les positions trouvées
        var positions = new List<int>();

        foreach (char c in text)
        {
            // On vérifie si le caractère est une lettre
            if (char.IsLetter(c))
            {
                /*
                 * Conversion pédagogique :
                 * 
                 * Les caractères sont représentés par des codes Unicode.
                 * Exemple :
                 * 'a' = 97
                 * 'b' = 98
                 * ...
                 * 
                 * Pour obtenir la position dans l'alphabet :
                 * 
                 * position = code_lettre - code_de_'a' + 1
                 */

                int position = char.ToLower(c) - 'a' + 1;

                positions.Add(position);
            }
        }

        // Les positions sont ensuite jointes avec un espace
        return string.Join(" ", positions);
    }

    /**
     * Version alternative utilisant LINQ pour une approche plus concise.
     */
    public static string AlphabetPositionLinq(string text)
    {
        return string.Join(" ",
            text.ToLower()
                .Where(char.IsLetter)
                .Select(c => c - 'a' + 1));
    }
}
