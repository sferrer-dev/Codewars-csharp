namespace DirectionsReduction;

/// <summary>
/// Fournit une solution au kata "Directions Reduction".
/// </summary>
/// <remarks>
/// Le but est de simplifier une suite de directions cardinales
/// en supprimant les paires opposées adjacentes :
/// <list type="bullet">
/// <item><description>NORTH annule SOUTH</description></item>
/// <item><description>SOUTH annule NORTH</description></item>
/// <item><description>EAST annule WEST</description></item>
/// <item><description>WEST annule EAST</description></item>
/// </list>
/// </remarks>
public class DirReduction
{
    /// <summary>
    /// Réduit un chemin en supprimant les directions opposées adjacentes.
    /// </summary>
    /// <param name="arr">Tableau de directions à simplifier.</param>
    /// <returns>
    /// Un nouveau tableau contenant le chemin réduit.
    /// </returns>
    public static string[] dirReduc(string[] arr)
    {
        // Dictionnaire associant chaque direction à son opposée.
        Dictionary<string, string> opposites = new(StringComparer.Ordinal)
        {
            ["NORTH"] = "SOUTH",
            ["SOUTH"] = "NORTH",
            ["EAST"] = "WEST",
            ["WEST"] = "EAST"
        };

        // La pile mémorise le chemin réduit au fur et à mesure.
        Stack<string> reducedDirections = new();

        foreach (string direction in arr)
        {
            // Si la pile contient déjà une direction
            // et que la direction courante annule celle du sommet,
            // alors on dépile au lieu d'empiler.
            if (reducedDirections.Count > 0 &&
                opposites[direction] == reducedDirections.Peek())
            {
                reducedDirections.Pop();
                continue;
            }

            // Sinon, la direction courante reste dans le chemin.
            reducedDirections.Push(direction);
        }

        // Une pile restitue les éléments dans l'ordre inverse,
        // donc on renverse le résultat pour retrouver l'ordre initial.
        return reducedDirections.Reverse().ToArray();
    }
}
