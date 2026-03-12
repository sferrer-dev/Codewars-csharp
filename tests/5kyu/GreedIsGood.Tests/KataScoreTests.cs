namespace GreedIsGood.Tests;

/// <summary>
/// Contient les tests unitaires de la méthode <c>Score</c> de la classe <c>Kata</c>.
/// </summary>
[TestFixture]
public sealed class KataScoreTests
{
    /// <summary>
    /// Vérifie qu'un lancer ne contenant aucune combinaison gagnante retourne zéro.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainNoScoringCombination_ShouldReturnZero()
    {
        int[] dice = [2, 3, 4, 6, 2];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(0));
    }

    /// <summary>
    /// Vérifie qu'un brelan de quatre retourne correctement 400 points.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeFours_ShouldReturnFourHundred()
    {
        int[] dice = [4, 4, 4, 3, 3];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(400));
    }

    /// <summary>
    /// Vérifie qu'une combinaison mixte composée d'un brelan et d'un cinq isolé
    /// retourne le score attendu.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeFoursAndOneFive_ShouldReturnFourHundredFifty()
    {
        int[] dice = [2, 4, 4, 5, 4];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(450));
    }

    /// <summary>
    /// Vérifie qu'un brelan de uns retourne 1000 points.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeOnes_ShouldReturnOneThousand()
    {
        int[] dice = [1, 1, 1, 2, 3];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(1000));
    }

    /// <summary>
    /// Vérifie que des uns isolés hors brelan sont correctement valorisés.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainSingleOnesWithoutTriplet_ShouldReturnOneHundredPerOne()
    {
        int[] dice = [1, 2, 1, 3, 4];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(200));
    }

    /// <summary>
    /// Vérifie que des cinq isolés hors brelan sont correctement valorisés.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainSingleFivesWithoutTriplet_ShouldReturnFiftyPerFive()
    {
        int[] dice = [5, 2, 5, 3, 4];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(100));
    }

    /// <summary>
    /// Vérifie qu'un brelan de cinq additionné à un cinq isolé retourne le score attendu.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeFivesAndOneAdditionalFive_ShouldReturnFiveHundredFifty()
    {
        int[] dice = [5, 5, 5, 5, 2];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(550));
    }

    /// <summary>
    /// Vérifie qu'un brelan de uns additionné à des points unitaires restants
    /// retourne le score attendu.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeOnesAndOneAdditionalOneAndOneFive_ShouldReturnOneThousandOneHundredFifty()
    {
        int[] dice = [1, 1, 1, 1, 5];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(1150));
    }

    /// <summary>
    /// Vérifie qu'un brelan de deux retourne 200 points.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeTwos_ShouldReturnTwoHundred()
    {
        int[] dice = [2, 2, 2, 3, 4];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(200));
    }

    /// <summary>
    /// Vérifie qu'un brelan de six retourne 600 points.
    /// </summary>
    [Test]
    public void Score_WhenDiceContainThreeSixes_ShouldReturnSixHundred()
    {
        int[] dice = [6, 6, 6, 2, 3];

        int result = Kata.Score(dice);

        Assert.That(result, Is.EqualTo(600));
    }

    /// <summary>
    /// Vérifie qu'un lancer nul déclenche une exception adaptée.
    /// </summary>
    [Test]
    public void Score_WhenDiceIsNull_ShouldThrowArgumentNullException()
    {
        Assert.That(() => Kata.Score(null!), Throws.ArgumentNullException);
    }
}