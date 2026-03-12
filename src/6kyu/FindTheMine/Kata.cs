namespace FindTheMine;

public class Kata
{
    public static Tuple<int, int> MineLocation(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int column = 0; column < field.GetLength(1); column++)
            {
                if (field[row, column] == 1)
                {
                    return new Tuple<int, int>(row, column);
                }
            }
        }

        throw new InvalidOperationException("No mines found in the field");
    }
}
