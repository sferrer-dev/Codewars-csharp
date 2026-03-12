using System;

/// <summary>
/// Implémentation du kata Codewars "Strip Comments".
/// 
/// Objectif :
/// Supprimer, ligne par ligne, tout le texte qui suit un ou plusieurs marqueurs
/// de commentaire, puis retirer les espaces blancs en fin de ligne.
/// 
/// Exemple :
/// "apples, pears # and bananas"  -->  "apples, pears"
/// </summary>
public static class StripCommentsSolution
{
    /// <summary>
    /// Supprime les commentaires d'un texte multi-lignes.
    /// 
    /// Pour chaque ligne :
    /// - on détecte le premier marqueur de commentaire rencontré,
    /// - on supprime tout ce qui se trouve après ce marqueur,
    /// - on supprime les espaces blancs en fin de ligne.
    /// 
    /// Les sauts de ligne sont conservés.
    /// </summary>
    /// <param name="text">Texte d'entrée, potentiellement multi-lignes.</param>
    /// <param name="commentSymbols">
    /// Tableau des marqueurs de commentaires (ex : "#", "!", "$").
    /// </param>
    /// <returns>Le texte nettoyé des commentaires.</returns>
    public static string StripComments(string text, string[] commentSymbols)
    {
        // Garde-fous : on refuse explicitement les entrées nulles.
        ArgumentNullException.ThrowIfNull(text);
        ArgumentNullException.ThrowIfNull(commentSymbols);

        // Découpe du texte en lignes à partir du caractère '\n'.
        // (les fins de ligne Windows "\r\n" seront gérées plus loin)
        var lines = text.Split('\n');

        // Traitement indépendant de chaque ligne.
        for (var i = 0; i < lines.Length; i++)
        {
            lines[i] = ProcessLine(lines[i], commentSymbols);
        }

        // Reconstruction du texte en conservant les sauts de ligne.
        return string.Join('\n', lines);
    }

    /// <summary>
    /// Traite une ligne unique :
    /// - supprime un éventuel caractère '\r' résiduel,
    /// - supprime la partie commentaire,
    /// - supprime les espaces en fin de ligne.
    /// </summary>
    /// <param name="line">Ligne à traiter.</param>
    /// <param name="commentSymbols">Marqueurs de commentaire.</param>
    /// <returns>La ligne nettoyée.</returns>
    private static string ProcessLine(string line, string[] commentSymbols)
    {
        // Support CRLF (Windows) :
        // après un Split('\n'), il peut rester un '\r' en fin de ligne.
        if (line.EndsWith('\r'))
        {
            line = line[..^1];
        }

        // Recherche de la position du premier marqueur de commentaire.
        var cutIndex = FindFirstMarkerIndex(line, commentSymbols);

        // Si aucun marqueur n'est trouvé (cutIndex == -1),
        // on conserve la ligne entière.
        // Sinon, on conserve uniquement la partie avant le marqueur.
        var contentBeforeComment = cutIndex < 0
            ? line
            : line[..cutIndex];

        // Suppression des espaces et tabulations en fin de ligne.
        return contentBeforeComment.TrimEnd();
    }

    /// <summary>
    /// Recherche l'index du premier marqueur de commentaire présent dans la ligne.
    /// 
    /// Si plusieurs marqueurs sont trouvés, on retient celui dont la position
    /// est la plus à gauche.
    /// </summary>
    /// <param name="line">Ligne analysée.</param>
    /// <param name="commentSymbols">Marqueurs de commentaire.</param>
    /// <returns>
    /// Index du premier marqueur trouvé, ou -1 si aucun marqueur n'est présent.
    /// </returns>
    private static int FindFirstMarkerIndex(string line, string[] commentSymbols)
    {
        // -1 signifie : aucun marqueur trouvé pour l'instant.
        var firstIndex = -1;

        // Parcours de tous les marqueurs fournis.
        for (var i = 0; i < commentSymbols.Length; i++)
        {
            var marker = commentSymbols[i];

            // On ignore les marqueurs invalides (null ou chaîne vide).
            if (string.IsNullOrEmpty(marker))
            {
                continue;
            }

            // Recherche du marqueur dans la ligne (comparaison stricte).
            var index = line.IndexOf(marker, StringComparison.Ordinal);

            // Si le marqueur n'est pas présent, on passe au suivant.
            if (index < 0)
            {
                continue;
            }

            // Si c'est le premier marqueur trouvé ou s'il est plus à gauche
            // que le précédent, on met à jour la position retenue.
            if (firstIndex == -1 || index < firstIndex)
            {
                firstIndex = index;
            }
        }

        return firstIndex;
    }
}
