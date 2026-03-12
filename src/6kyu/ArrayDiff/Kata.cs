namespace ArrayDiff;
public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        ArgumentNullException.ThrowIfNull(a);
        ArgumentNullException.ThrowIfNull(b);

        List<int> result = new List<int>();

        var excluded = new HashSet<int>(b);

        foreach (int value in a)
        {
            if (!excluded.Contains(value))
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }
}
