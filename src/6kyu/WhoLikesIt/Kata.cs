namespace WhoLikesIt;

public class Kata
{
    public static string Likes(string[] name)
    {
        int cpt = name.Length;
        string sentence = string.Empty;

        switch (cpt)
        {
            case 0:
                sentence = "no one likes this";
                break;

            case 1:
                sentence = $"{name[0]} likes this";
                break;

            case 2:
                sentence = $"{name[0]} and {name[1]} like this";
                break;

            case 3:
                sentence = $"{name[0]}, {name[1]} and {name[2]} like this";
                break;

            default:
                sentence = $"{name[0]}, {name[1]} and {cpt - 2} others like this";
                break;
        }

        return sentence;
    }

    /// <summary>
    /// Construit le texte affiché à côté d’un élément "aimé" en fonction des personnes l’ayant aimé.
    /// </summary>
    /// <param name="names">Tableau des noms des personnes ayant aimé l’élément.</param>
    /// <returns>Une phrase conforme aux règles du kata.</returns>
    /// <exception cref="ArgumentNullException">Levée si <paramref name="names"/> est null.</exception>
    public static string LikesClean(string[] names)
    {
        ArgumentNullException.ThrowIfNull(names);

        return names.Length switch
        {
            0 => "no one likes this",
            1 => $"{names[0]} likes this",
            2 => $"{names[0]} and {names[1]} like this",
            3 => $"{names[0]}, {names[1]} and {names[2]} like this",
            _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this"
        };
    }


}
