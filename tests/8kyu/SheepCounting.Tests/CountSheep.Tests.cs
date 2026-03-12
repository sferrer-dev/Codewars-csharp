using SheepCounter;

namespace SheepCounting.Tests;

/// <summary>
/// Tests unitaires pour la classe <see cref="CountingSheep.Kata"/>.
/// </summary>
[TestFixture]
public class CountingSheepTests
{
    [Test]
    public void CountSheep_Should_Return_17_For_Sample_Input()
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
        var result = Kata.CountSheep(sheep);

        // Assert
        Assert.AreEqual(17, result);
    }

    [Test]
    public void CountSheep_Should_Return_0_For_Empty_List()
    {
        // Arrange
        var sheep = new List<bool?>();

        // Act
        var result = Kata.CountSheep(sheep);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void CountSheep_Should_Ignore_Null_Values()
    {
        // Arrange
        var sheep = new List<bool?> { true, null, false, true, null };

        // Act
        var result = Kata.CountSheep(sheep);

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void CountSheep_Should_Return_0_For_Null_Input()
    {
        // Act
        var result = Kata.CountSheep(null);

        // Assert
        Assert.AreEqual(0, result);
    }
}
