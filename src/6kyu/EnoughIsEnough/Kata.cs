namespace EnoughIsEnough;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        if (x <= 0)
        {
            return Array.Empty<int>();
        }

        var result = new List<int>();
        // Dictionnaire de comptage :
        // clé   = valeur rencontrée
        // valeur = nombre de fois où elle a déjà été ajoutée au résultat
        var occurrences = new Dictionary<int, int>();

        foreach (var value in arr)
        {
            if (!occurrences.ContainsKey(value))
            {
                occurrences[value] = 0;
            }

            if (occurrences[value] < x)
            {
                result.Add(value);
                occurrences[value]++;
            }
        }

        return result.ToArray();
    }

}
