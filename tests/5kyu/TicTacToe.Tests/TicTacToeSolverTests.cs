namespace TicTacToe.Tests;

/// <summary>
/// Tests unitaires de la classe <see cref="TicTacToe"/>.
/// Vérifie les différents états possibles d'une partie.
/// </summary>
[TestFixture]
public class TicTacToeSolverTests
{
    private TicTacToe _sut;

    /// <summary>
    /// Initialisation avant chaque test.
    /// </summary>
    [SetUp]
    public void SetUp()
    {
        _sut = new TicTacToe();
    }

    [Test]
    public void IsSolved_Should_Return_X_Winner_When_Row_Is_Filled_With_X()
    {
        int[,] board =
        {
            {1,1,1},
            {0,2,2},
            {0,0,0}
        };

        int result = _sut.IsSolved(board);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void IsSolved_Should_Return_O_Winner_When_Column_Is_Filled_With_O()
    {
        int[,] board =
        {
            {2,1,0},
            {2,1,0},
            {2,0,1}
        };

        int result = _sut.IsSolved(board);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void IsSolved_Should_Return_X_Winner_When_Diagonal_Is_Filled()
    {
        int[,] board =
        {
            {1,2,0},
            {0,1,2},
            {0,0,1}
        };

        int result = _sut.IsSolved(board);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void IsSolved_Should_Return_Draw_When_Board_Is_Full_And_No_Winner()
    {
        int[,] board =
        {
            {1,2,1},
            {1,2,2},
            {2,1,1}
        };

        int result = _sut.IsSolved(board);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void IsSolved_Should_Return_NotFinished_When_Empty_Cells_Remain_And_No_Winner()
    {
        int[,] board =
        {
            {1,2,1},
            {0,2,2},
            {2,1,1}
        };

        int result = _sut.IsSolved(board);

        Assert.That(result, Is.EqualTo(-1));
    }
}