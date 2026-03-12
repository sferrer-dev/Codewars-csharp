using System.Text;

namespace FilterTheNumber;

public class Kata
{
    public static int FilterStringWithoutLinq(string s)
    {
        var sb = new StringBuilder();
        foreach (char c in s)
        {
            if (Char.IsDigit(c))
            {
                sb.Append(c);
            }
        }

        return sb.Length > 0 ? int.Parse(sb.ToString()) : 0;
    }

    public static int FilterString(string s)
    {
        var digits = s.Where(c => c >= '0' && c <= '9');
        return digits.Any() ? int.Parse(new string(digits.ToArray())) : 0;
    }

}
