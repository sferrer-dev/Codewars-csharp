namespace Snail.Tests;

/// <summary>
/// Contient les tests unitaires de l'algorithme Snail.
/// </summary>
[TestFixture]
public class SnailCleanTests
{
    /// <summary>
    /// Vérifie le parcours snail d'une matrice 3x3.
    /// </summary>
    [Test]
    [Order(1)]
    public void Snail_Should_Return_Expected_Result_For_3x3_Matrix()
    {
        int[][] array =
        {
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        };

        int[] expected = [1, 2, 3, 6, 9, 8, 7, 4, 5];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le parcours snail d'une matrice 4x4.
    /// </summary>
    [Test]
    [Order(2)]
    public void Snail_Should_Return_Expected_Result_For_4x4_Matrix()
    {
        int[][] array =
        {
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12],
            [13, 14, 15, 16]
        };

        int[] expected = [1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le comportement pour une matrice 1x1.
    /// </summary>
    [Test]
    [Order(3)]
    public void Snail_Should_Return_Single_Value_For_1x1_Matrix()
    {
        int[][] array =
        {
            [42]
        };

        int[] expected = [42];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le comportement pour une matrice vide.
    /// </summary>
    [Test]
    [Order(4)]
    public void Snail_Should_Return_Empty_Array_For_Empty_Matrix()
    {
        int[][] array = [];

        int[] expected = [];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le comportement pour une matrice contenant une ligne vide.
    /// </summary>
    [Test]
    [Order(5)]
    public void Snail_Should_Return_Empty_Array_For_Matrix_With_Empty_Row()
    {
        int[][] array =
        {
            []
        };

        int[] expected = [];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le parcours snail d'une matrice 2x2.
    /// </summary>
    [Test]
    [Order(6)]
    public void Snail_Should_Return_Expected_Result_For_2x2_Matrix()
    {
        int[][] array =
        {
            [1, 2],
            [3, 4]
        };

        int[] expected = [1, 2, 4, 3];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Vérifie le parcours snail d'une matrice 5x5.
    /// </summary>
    [Test]
    [Order(7)]
    public void Snail_Should_Return_Expected_Result_For_5x5_Matrix()
    {
        int[][] array =
        {
            [1, 2, 3, 4, 5],
            [6, 7, 8, 9, 10],
            [11, 12, 13, 14, 15],
            [16, 17, 18, 19, 20],
            [21, 22, 23, 24, 25]
        };

        int[] expected =
        [
            1, 2, 3, 4, 5,
            10, 15, 20, 25,
            24, 23, 22, 21,
            16, 11,
            6, 7, 8, 9,
            14, 19, 18, 17,
            12, 13
        ];

        AssertSnail(array, expected);
    }

    /// <summary>
    /// Convertit une matrice en texte lisible pour faciliter le diagnostic.
    /// </summary>
    /// <param name="array">Matrice à convertir.</param>
    /// <returns>Représentation textuelle de la matrice.</returns>
    private static string Int2dToString(int[][] array)
    {
        return $"[{string.Join("\n", array.Select(row => $"[{string.Join(",", row)}]"))}]";
    }

    /// <summary>
    /// Vérifie que le résultat du parcours snail correspond à l'attendu.
    /// </summary>
    /// <param name="array">Matrice d'entrée.</param>
    /// <param name="expected">Résultat attendu.</param>
    private static void AssertSnail(int[][] array, int[] expected)
    {
        int[] actual = SnailSolution.Snail(array);

        Assert.That(
            actual,
            Is.EqualTo(expected),
            $"Échec du parcours snail pour la matrice :{System.Environment.NewLine}{Int2dToString(array)}");
    }
}
