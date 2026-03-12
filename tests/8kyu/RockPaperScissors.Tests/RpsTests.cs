namespace RockPaperScissors.Tests;

/// <summary>
/// Tests unitaires pour la méthode Rps de la classe Kata, qui détermine le vainqueur d'une partie de pierre-papier-ciseaux.
/// </summary>
[TestFixture]
public class RpsTests
{
    private Kata _kata;
    /// <summary>
    /// Initialise une instance de la classe Kata avant chaque test.
    /// </summary>
    [SetUp]
    public void SetUp()
    {
        _kata = new Kata();
    }
    /// <summary>
    /// Vérifie que Player 1 gagne dans les cas valides.
    /// </summary>
    [TestCase("rock", "scissors", ExpectedResult = "Player 1 won!")]
    [TestCase("scissors", "paper", ExpectedResult = "Player 1 won!")]
    [TestCase("paper", "rock", ExpectedResult = "Player 1 won!")]
    [Order(1)]
    public string Player1Win(string p1, string p2)
    {
        return _kata.Rps(p1, p2);
    }
    /// <summary>
    /// Vérifie que Player 2 gagne dans les cas valides.
    /// </summary>
    [TestCase("scissors", "rock", ExpectedResult = "Player 2 won!")]
    [TestCase("paper", "scissors", ExpectedResult = "Player 2 won!")]
    [TestCase("rock", "paper", ExpectedResult = "Player 2 won!")]
    [Order(2)]
    public string Player2Win(string p1, string p2)
    {
        return _kata.Rps(p1, p2);
    }
    /// <summary>
    /// Vérifie les cas d'égalité.
    /// </summary>
    [TestCase("rock", "rock", ExpectedResult = "Draw!")]
    [TestCase("scissors", "scissors", ExpectedResult = "Draw!")]
    [TestCase("paper", "paper", ExpectedResult = "Draw!")]
    [Order(3)]
    public string Draw(string p1, string p2)
    {
        return _kata.Rps(p1, p2);
    }
}
