using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FindTheMine.Tests;

[TestFixture]
public class FindTheMineTests
{
    public static IEnumerable<TestCaseData> MineLocationCases()
    {
        yield return new TestCaseData(new int[,] { { 1, 0 }, { 0, 0 } }, 0, 0)
            .SetName("MineLocation_2x2_Mine_At_0_0");

        yield return new TestCaseData(
                new int[,] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } },
                0, 0)
            .SetName("MineLocation_3x3_Mine_At_0_0");

        yield return new TestCaseData(
                new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } },
                2, 2)
            .SetName("MineLocation_4x4_Mine_At_2_2");

        yield return new TestCaseData(
                new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 1, 0 } },
                2, 1)
            .SetName("MineLocation_3x3_Mine_At_2_1");
    }

    [TestCaseSource(nameof(MineLocationCases))]
    public void MineLocation_Should_Return_Coordinates(int[,] field, int expectedRow, int expectedColumn)
    {
        Tuple<int, int> result = Kata.MineLocation(field);

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Item1, Is.EqualTo(expectedRow));
        Assert.That(result.Item2, Is.EqualTo(expectedColumn));
    }

    [Test]
    public void MineLocation_Should_Throw_InvalidOperationException_When_No_Mine_Found()
    {
        int[,] field =
        {
            { 0, 0 },
            { 0, 0 }
        };

        var ex = Assert.Throws<InvalidOperationException>(() => Kata.MineLocation(field));
        Assert.That(ex!.Message, Is.EqualTo("No mines found in the field"));
    }
}
