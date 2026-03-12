namespace StringsMix;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Implémentation du Kata Codewars 4kyu "Strings Mix".
/// 
/// L'objectif est de comparer les fréquences des lettres minuscules
/// entre deux chaînes et de produire une représentation textuelle
/// indiquant dans quelle chaîne chaque lettre apparaît le plus.
/// </summary>
public class Mixing
{
    /// <summary>
    /// Compare les fréquences des lettres minuscules entre deux chaînes.
    /// </summary>
    /// <param name="s1">Première chaîne à analyser.</param>
    /// <param name="s2">Deuxième chaîne à analyser.</param>
    /// <returns>
    /// Une chaîne décrivant les différences de fréquences sous forme :
    /// "1:aaa/2:bb/=:cc"
    /// </returns>
    public static string Mix(string s1, string s2)
    {
        // Compte les occurrences des lettres a..z dans chaque chaîne
        int[] count1 = CountLetters(s1);
        int[] count2 = CountLetters(s2);

        var parts = new List<string>();

        // Parcours de toutes les lettres de l'alphabet
        for (int i = 0; i < 26; i++)
        {
            int c1 = count1[i];
            int c2 = count2[i];

            int max = Math.Max(c1, c2);

            // On ignore les lettres apparaissant au plus une fois
            if (max <= 1)
                continue;

            char letter = (char)('a' + i);

            if (c1 > c2)
                parts.Add($"1:{new string(letter, c1)}");
            else if (c2 > c1)
                parts.Add($"2:{new string(letter, c2)}");
            else
                parts.Add($"=:{new string(letter, c1)}");
        }

        // Tri selon les règles du kata :
        // 1. longueur décroissante
        // 2. ordre lexicographique
        return string.Join("/",
            parts
                .OrderByDescending(part => part.Length)
                .ThenBy(part => GetPrefixOrder(part[0]))
                .ThenBy(part => part[2]));
    }

    /// <summary>
    /// Compte les occurrences des lettres minuscules (a..z)
    /// dans une chaîne donnée.
    /// </summary>
    private static int[] CountLetters(string s)
    {
        int[] counts = new int[26];

        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                counts[c - 'a']++;
            }
        }

        return counts;
    }

    /// <summary>
    /// Retourne l'ordre de tri des préfixes :
    /// 1 avant 2 avant =.
    /// </summary>
    /// <param name="prefix">Premier caractère du segment.</param>
    /// <returns>Valeur numérique de priorité de tri.</returns>
    private static int GetPrefixOrder(char prefix)
    {
        return prefix switch
        {
            '1' => 0,
            '2' => 1,
            '=' => 2,
            _ => 3
        };
    }

    /// <summary>
    /// Compare les fréquences des lettres minuscules entre deux chaînes
    /// et construit une représentation textuelle décrivant
    /// dans quelle chaîne chaque lettre apparaît le plus.
    /// </summary>
    /// <param name="s1">Première chaîne à analyser.</param>
    /// <param name="s2">Deuxième chaîne à analyser.</param>
    /// <returns>
    /// Une chaîne formatée selon les règles du kata :
    /// <c>1:aaa/2:bb/=:cc</c>
    /// </returns>
    public static string MixWithLinq(string s1, string s2)
    {
        return string.Join("/",
            // Parcourt toutes les lettres de l'alphabet (0 → 25)
            Enumerable.Range(0, 26)

                // Pour chaque lettre, calcule les informations nécessaires
                .Select(i =>
                {
                    // Conversion de l'indice en caractère ('a' → 'z')
                    char letter = (char)('a' + i);

                    // Compte le nombre d'occurrences de cette lettre dans chaque chaîne
                    int count1 = s1.Count(c => c == letter);
                    int count2 = s2.Count(c => c == letter);

                    // Détermine le nombre maximal d'occurrences entre les deux chaînes
                    int max = Math.Max(count1, count2);

                    // Construit un objet anonyme contenant les informations utiles
                    return new
                    {
                        Letter = letter,   // lettre analysée
                        Max = max,         // fréquence maximale
                                           // Préfixe indiquant la chaîne dominante
                        Prefix = count1 > count2 ? "1:" :
                                 count2 > count1 ? "2:" : "=:"
                    };
                })

                // On ignore les lettres apparaissant au plus une fois
                .Where(x => x.Max > 1)

                // Tri principal : nombre d'occurrences décroissant
                .OrderByDescending(x => x.Max)

                // Tri secondaire : origine de la chaîne (1 puis 2 puis =)
                .ThenBy(x => x.Prefix[0] == '1' ? 0 : x.Prefix[0] == '2' ? 1 : 2)

                // Tri tertiaire : ordre alphabétique de la lettre
                .ThenBy(x => x.Letter)

                // Construction de la chaîne finale pour chaque segment
                // Exemple : "1:aaa" ou "2:bb"
                .Select(x => x.Prefix + new string(x.Letter, x.Max)));
    }
}