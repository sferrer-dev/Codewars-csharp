namespace Sudoku.Tests;

/// <summary>
/// Tests unitaires vérifiant le comportement de la validation
/// d'une grille Sudoku de taille NxN.
/// </summary>
[TestFixture]
public class SudokuValidationTests
{
    /// <summary>
    /// Vérifie qu'un Sudoku 9x9 correctement rempli est validé.
    /// </summary>
    [Test]
    public void IsValid_Should_ReturnTrue_When_Sudoku9x9IsCorrect()
    {
        // Arrange
        var sudoku = new Sudoku(new int[][]
        {
            new[] {7,8,4,1,5,9,3,2,6},
            new[] {5,3,9,6,7,2,8,4,1},
            new[] {6,1,2,4,3,8,7,5,9},

            new[] {9,2,8,7,1,5,4,6,3},
            new[] {3,5,7,8,4,6,1,9,2},
            new[] {4,6,1,9,2,3,5,8,7},

            new[] {8,7,6,3,9,4,2,1,5},
            new[] {2,4,3,5,6,1,9,7,8},
            new[] {1,9,5,2,8,7,6,3,4}
        });

        // Act
        bool result = sudoku.IsValid();

        // Assert
        Assert.That(result, Is.True);
    }

    /// <summary>
    /// Vérifie qu'un Sudoku 4x4 correctement rempli est validé.
    /// </summary>
    [Test]
    public void IsValid_Should_ReturnTrue_When_Sudoku4x4IsCorrect()
    {
        // Arrange
        var sudoku = new Sudoku(new int[][]
        {
            new[] {1,4,2,3},
            new[] {3,2,4,1},

            new[] {4,1,3,2},
            new[] {2,3,1,4}
        });

        // Act
        bool result = sudoku.IsValid();

        // Assert
        Assert.That(result, Is.True);
    }

    /// <summary>
    /// Vérifie qu'une grille contenant des doublons est invalide.
    /// </summary>
    [Test]
    public void IsValid_Should_ReturnFalse_When_RowsContainDuplicates()
    {
        // Arrange
        var sudoku = new Sudoku(new int[][]
        {
            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9},

            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9},

            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9},
            new[] {1,2,3,4,5,6,7,8,9}
        });

        // Act
        bool result = sudoku.IsValid();

        // Assert
        Assert.That(result, Is.False);
    }

    /// <summary>
    /// Vérifie qu'une structure de grille invalide retourne false.
    /// </summary>
    [Test]
    public void IsValid_Should_ReturnFalse_When_GridStructureIsInvalid()
    {
        // Arrange
        var sudoku = new Sudoku(new int[][]
        {
            new[] {1,2,3,4,5},
            new[] {1,2,3,4},

            new[] {1,2,3,4},
            new[] {1}
        });

        // Act
        bool result = sudoku.IsValid();

        // Assert
        Assert.That(result, Is.False);
    }
}