namespace DirectionsReduction.Tests;

/// <summary>
/// Vérifie le comportement de la méthode <see cref="DirReduction.dirReduc(string[])"/>.
/// </summary>
[TestFixture]
public sealed class DirReductionTests
{
    /// <summary>
    /// Vérifie que la méthode réduit correctement un chemin
    /// contenant plusieurs annulations successives.
    /// </summary>
    [Test]
    public void DirReduc_Should_Return_Reduced_Path_When_Opposite_Directions_Cancel_Each_Other()
    {
        // Arrange
        string[] input = ["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"];
        string[] expected = ["WEST"];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode conserve le chemin tel quel
    /// lorsqu'aucune réduction n'est possible.
    /// </summary>
    [Test]
    public void DirReduc_Should_Return_Original_Path_When_No_Reduction_Is_Possible()
    {
        // Arrange
        string[] input = ["NORTH", "WEST", "SOUTH", "EAST"];
        string[] expected = ["NORTH", "WEST", "SOUTH", "EAST"];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode retourne un tableau vide
    /// lorsque le chemin d'entrée est vide.
    /// </summary>
    [Test]
    public void DirReduc_Should_Return_Empty_Array_When_Input_Is_Empty()
    {
        // Arrange
        string[] input = [];
        string[] expected = [];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode retourne un tableau vide
    /// lorsque toutes les directions s'annulent complètement.
    /// </summary>
    [Test]
    public void DirReduc_Should_Return_Empty_Array_When_All_Directions_Cancel_Out()
    {
        // Arrange
        string[] input = ["NORTH", "SOUTH", "EAST", "WEST"];
        string[] expected = [];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode gère correctement les annulations en chaîne
    /// apparues après une première réduction.
    /// </summary>
    [Test]
    public void DirReduc_Should_Handle_Chained_Reductions_Correctly()
    {
        // Arrange
        string[] input = ["NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST"];
        string[] expected = ["WEST", "WEST"];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie qu'une seule direction est conservée telle quelle.
    /// </summary>
    [TestCase("NORTH")]
    [TestCase("SOUTH")]
    [TestCase("EAST")]
    [TestCase("WEST")]
    public void DirReduc_Should_Return_Same_Single_Direction_When_Input_Contains_Only_One_Value(string direction)
    {
        // Arrange
        string[] input = [direction];
        string[] expected = [direction];

        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie plusieurs scénarios représentatifs de réduction.
    /// </summary>
    [TestCase(new[] { "NORTH", "SOUTH" }, new string[0])]
    [TestCase(new[] { "EAST", "WEST" }, new string[0])]
    [TestCase(new[] { "NORTH", "EAST", "WEST", "SOUTH" }, new string[0])]
    [TestCase(new[] { "NORTH", "NORTH", "SOUTH", "WEST", "EAST" }, new[] { "NORTH" })]
    [TestCase(new[] { "WEST", "EAST", "EAST", "WEST", "NORTH" }, new[] { "NORTH" })]
    public void DirReduc_Should_Return_Expected_Result_For_Multiple_Scenarios(string[] input, string[] expected)
    {
        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
