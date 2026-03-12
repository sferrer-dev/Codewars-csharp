namespace SimplePigLatin;

/// <summary>
/// Implémentation du Kata Codewars "Simple Pig Latin".
/// Transforme chaque mot d'une phrase en Pig Latin :
/// - la première lettre est déplacée à la fin du mot
/// - la chaîne "ay" est ajoutée
/// La ponctuation est laissée inchangée.
/// </summary>
public class Kata
{
    /// <summary>
    /// Convertit une phrase en Pig Latin.
    /// </summary>
    /// <param name="str">Phrase à transformer.</param>
    /// <returns>Phrase transformée en Pig Latin.</returns>
    public static string PigIt(string str)
    {
        var words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            // Si le word est une ponctuation, on ne le modifie pas
            if (!char.IsLetter(word[0]))
                continue;
            words[i] = word[1..] + word[0] + "ay";
        }
        return string.Join(" ", words);
    }
    /// <summary>
    /// Convertit une phrase en Pig Latin.
    /// Chaque mot voit sa première lettre déplacée à la fin
    /// puis la chaîne "ay" est ajoutée.
    /// La ponctuation est laissée inchangée.
    /// </summary>
    /// <param name="str">Phrase à transformer.</param>
    /// <returns>Phrase convertie en Pig Latin.</returns>
    public static string PigItLinq(string str)
    {
        return string.Join(" ",
            str.Split(' ')
               .Select(word =>
                   char.IsLetter(word[0])
                       ? word[1..] + word[0] + "ay"
                       : word
               ));
    }
}
