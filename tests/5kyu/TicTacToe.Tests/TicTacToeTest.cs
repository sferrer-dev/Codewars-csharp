namespace TicTacToe.Tests;

[TestFixture]
public class TicTacToeTest
{
    private TicTacToe tictactoe = new TicTacToe();

    [Test]
    public void test1()
    {
        int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
        Assert.That(tictactoe.IsSolved(board), Is.EqualTo(1));
    }
}