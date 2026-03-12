namespace CalculateStringRotation;

public class CalculateStringRotation
{
    public static int ShiftedDiff(string first, string second)
    {
        if (first is null || second is null)
            return -1;
        if (first.Length != second.Length)
            return -1;
        if (first.Length == 0)
            return 0;
        if (string.Equals(first, second, StringComparison.Ordinal))
            return 0;

        var doubled = string.Concat(second, second);
        var index = doubled.IndexOf(first, StringComparison.Ordinal);

        return (index >= 0 && index < second.Length) ? index : -1;
    }
}
