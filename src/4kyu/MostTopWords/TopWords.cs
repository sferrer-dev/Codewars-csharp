using System.Text.RegularExpressions;

namespace MostTopWords;

/// <summary>
/// Fournit une méthode permettant d'extraire
/// les 3 mots les plus fréquents dans un texte.
/// </summary>
public class TopWords
{
    /// <summary>
    /// Retourne les trois mots les plus fréquents d'un texte.
    /// </summary>
    /// <param name="s">
    /// Texte d'entrée pouvant contenir ponctuation, espaces et retours à la ligne.
    /// </param>
    /// <returns>
    /// Liste contenant les trois mots les plus fréquents (ou moins si le texte
    /// contient moins de mots distincts).
    /// </returns>
    public static List<string> Top3(string s)
    {
        // Si la chaîne est nulle ou vide, on retourne une liste vide.
        if (string.IsNullOrWhiteSpace(s))
            return new List<string>();

        /*
         Expression régulière permettant d'extraire les mots valides.

         [a-zA-Z']+  -> séquence de lettres ou apostrophes
         
         Nous filtrerons ensuite les séquences composées uniquement
         d'apostrophes (ex : "'", "'''").
        */
        var matches = Regex.Matches(s.ToLower(), @"[a-z']+");

        // Dictionnaire permettant de compter les occurrences de chaque mot.
        Dictionary<string, int> frequencies = new();

        foreach (Match match in matches)
        {
            string word = match.Value;

            // On ignore les séquences composées uniquement d'apostrophes.
            if (word.All(c => c == '\''))
                continue;

            // Incrémentation du compteur.
            if (frequencies.ContainsKey(word))
                frequencies[word]++;
            else
                frequencies[word] = 1;
        }

        /*
         Sélection des 3 mots les plus fréquents.

         OrderByDescending -> tri par fréquence
         Take(3)           -> on garde les 3 premiers
         Select            -> on récupère uniquement le mot
        */
        return frequencies
            .OrderByDescending(kv => kv.Value)
            .Take(3)
            .Select(kv => kv.Key)
            .ToList();
    }

    /// <summary>
    /// Analyse un texte et retourne les trois mots les plus fréquents.
    /// </summary>
    /// <param name="s">Texte à analyser.</param>
    /// <returns>Liste des trois mots les plus fréquents en minuscules.</returns>
    public static List<string> Top3Linq(string s)
    {
        return Regex.Matches(s.ToLower(), @"[a-z']+")
            // Recherche dans le texte toutes les séquences composées
            // de lettres (a-z) ou d'apostrophes.
            // Le texte est d'abord converti en minuscules afin de rendre
            // la comparaison insensible à la casse.

            .Select(m => m.Value)
            // Chaque correspondance Regex (Match) est transformée
            // en sa valeur textuelle (le mot trouvé).

            .Where(w => w.Any(char.IsLetter))
            // Filtre les correspondances invalides composées uniquement
            // d'apostrophes comme "'" ou "'''".
            // Un mot valide doit contenir au moins une lettre.

            .GroupBy(w => w)
            // Regroupe tous les mots identiques ensemble.
            // Chaque groupe représente un mot unique et toutes ses occurrences.

            .OrderByDescending(g => g.Count())
            // Trie les groupes par nombre d'occurrences décroissant
            // afin d'obtenir les mots les plus fréquents en premier.

            .Take(3)
            // Ne conserve que les 3 groupes les plus fréquents.

            .Select(g => g.Key)
            // Récupère uniquement le mot associé à chaque groupe.

            .ToList();
        // Convertit la séquence finale en List<string>
        // conformément au type de retour demandé par la fonction.
    }
}