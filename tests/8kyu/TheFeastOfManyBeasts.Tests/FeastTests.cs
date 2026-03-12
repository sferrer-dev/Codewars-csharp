using NUnit.Framework;

namespace TheFeastOfManyBeasts.Tests;

/// <summary>
/// Tests unitaires pour la méthode Feast de la classe Kata.
/// </summary>
[TestFixture]
public class FeastTests
{
    /// <summary>
    /// Vérifie que la méthode Feast retourne true pour des cas valides
    /// où le plat commence et se termine par les mêmes lettres que le nom de l'animal.
    /// </summary>
    /// <param name="beast">Nom de l'animal.</param>
    /// <param name="dish">Nom du plat.</param>
    [TestCase("great blue heron", "garlic naan")]
    [TestCase("chickadee", "chocolate cake")]
    [Order(1)]
    public void Feast_ShouldReturnTrue_WhenDishMatchesBeast(string beast, string dish)
    {
        // Act
        bool result = Kata.Feast(beast, dish);

        // Assert
        Assert.That(result, Is.True);
    }

    /// <summary>
    /// Vérifie que la méthode Feast retourne false pour des cas invalides
    /// où le plat ne respecte pas la règle du festin.
    /// </summary>
    /// <param name="beast">Nom de l'animal.</param>
    /// <param name="dish">Nom du plat.</param>
    [TestCase("brown bear", "bear claw")]
    [TestCase("parrot", "orange tart")]
    [Order(2)]
    public void Feast_ShouldReturnFalse_WhenDishDoesNotMatchBeast(string beast, string dish)
    {
        // Act
        bool result = Kata.Feast(beast, dish);

        // Assert
        Assert.That(result, Is.False);
    }

    /// <summary>
    /// Vérifie que la méthode Feast retourne le résultat attendu pour plusieurs cas de test regroupés.
    /// </summary>
    /// <param name="expected">Résultat attendu du test.</param>
    /// <param name="testData">Tableau contenant les paires (beast, dish) à tester.</param>
    [TestCase(true, new object[] { "great blue heron", "garlic naan", "chickadee", "chocolate cake" })]
    [TestCase(false, new object[] { "brown bear", "bear claw", "parrot", "orange tart" })]
    public void Feast_GroupedCases_ShouldReturnExpectedResults(bool expected, object[] testData)
    {
        for (int i = 0; i < testData.Length; i += 2)
        {
            string beast = testData[i].ToString();
            string dish = testData[i + 1].ToString();
            bool result = Kata.Feast(beast, dish);

            Assert.That(result, Is.EqualTo(expected),
                $"Échec pour le cas : beast = '{beast}', dish = '{dish}'");
        }
    }
}
