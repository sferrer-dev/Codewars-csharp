using SheepCounter;

namespace SheepCounting.Tests;

/// <summary>
/// Tests unitaires pour la classe <see cref="CountingSheepWithoutLinqTests.Kata"/>.
/// validant le comportement de la méthode  <c>CountSheepWithoutLinq</c> du kata « Counting Sheep ».
/// </summary>
[TestFixture]
public class CountingSheepWithoutLinqTests
{
    /// <summary>
    /// Vérifie que la méthode retourne correctement le nombre de moutons présents
    /// pour l’exemple fourni dans l’énoncé du kata.
    /// </summary>
    [Test]
    public void CountSheepWithoutLinq_Should_Return_17_For_Sample_Input()
    {
        // Arrange
        var sheep = new List<bool?>
            {
                true, true, true, false,
                true, true, true, true,
                true, false, true, false,
                true, false, false, true,
                true, true, true, true,
                false, false, true, true
            };

        // Act
        var result = Kata.CountSheepWithoutLinq(sheep);

        // Assert
        Assert.AreEqual(17, result);
    }

    /// <summary>
    /// Vérifie que les valeurs nulles dans la collection sont ignorées
    /// lors du comptage des moutons présents.
    /// </summary>
    [Test]
    public void CountSheepWithoutLinq_Should_Ignore_Null_Values()
    {
        // Arrange
        var sheep = new List<bool?> { true, null, false, true, null };

        // Act
        var result = Kata.CountSheepWithoutLinq(sheep);

        // Assert
        Assert.AreEqual(2, result);
    }

    /// <summary>
    /// Vérifie que la méthode retourne zéro lorsque la collection
    /// de moutons est vide.
    /// </summary>
    [Test]
    public void CountSheepWithoutLinq_Should_Return_0_For_Empty_List()
    {
        // Arrange
        var sheep = new List<bool?>();

        // Act
        var result = Kata.CountSheepWithoutLinq(sheep);

        // Assert
        Assert.AreEqual(0, result);
    }

    /// <summary>
    /// Vérifie que la méthode retourne zéro lorsque le paramètre
    /// passé est nul, sans lever d’exception.
    /// </summary>
    [Test]
    public void CountSheepWithoutLinq_Should_Return_0_For_Null_Input()
    {
        // Act
        var result = Kata.CountSheepWithoutLinq(null);

        // Assert
        Assert.AreEqual(0, result);
    }
}

