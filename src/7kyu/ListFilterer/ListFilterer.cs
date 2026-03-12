namespace ListFilterer;

public class ListFilterer
{

    /// <summary>
    /// Extrait uniquement les entiers présents dans une liste d'objets.
    /// </summary>
    /// <param name="listOfItems">Liste contenant des objets de types variés.</param>
    /// <returns>
    /// Une collection d'entiers correspondant aux éléments de type <see cref="int"/>.
    /// </returns>
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems
            .OfType<int>();
    }

    public static IEnumerable<int> GetIntegersFromListWithoutLink(List<object> listOfItems)
    {
        var result = new List<int>();

        foreach (var item in listOfItems)
        {
            if (item is int value)
            {
                result.Add(value);
            }
        }

        return result;
    }
}
