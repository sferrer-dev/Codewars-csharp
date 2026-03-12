namespace DirectionsReduction.Tests;

[TestFixture]
public sealed class DirReductionCaseTests
{
    [TestCaseSource(nameof(ReductionScenarios))]
    public void DirReduc_Should_Return_Expected_Result_For_Multiple_Scenarios(string[] input, string[] expected)
    {
        // Act
        string[] actual = DirReduction.dirReduc(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> ReductionScenarios()
    {
        yield return new TestCaseData(
            new[] { "NORTH", "SOUTH" },
            new string[0]);

        yield return new TestCaseData(
            new[] { "EAST", "WEST" },
            new string[0]);

        yield return new TestCaseData(
            new[] { "NORTH", "EAST", "WEST", "SOUTH" },
            new string[0]);

        yield return new TestCaseData(
            new[] { "NORTH", "NORTH", "SOUTH", "WEST", "EAST" },
            new[] { "NORTH" });

        yield return new TestCaseData(
            new[] { "WEST", "EAST", "EAST", "WEST", "NORTH" },
            new[] { "NORTH" });
    }
}