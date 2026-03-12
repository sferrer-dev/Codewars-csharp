namespace ReduceButGrow.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Contient les tests unitaires pour la méthode <c>Grow</c> de la classe <c>Kata</c>.
    /// </summary>
    [TestFixture]
    public class GrowTests
    {
        /// <summary>
        /// Vérifie que la méthode <see cref="Kata.Grow(int[])"/> retourne correctement le produit
        /// de tous les éléments du tableau d'entiers fourni.
        /// </summary>
        /// <param name="elements">Le tableau d'entiers à multiplier.</param>
        /// <param name="expected">Le résultat attendu du produit.</param>
        [TestCase(new[] { 1, 2, 3 }, 6, TestName = "Grow_ProductOf_1_2_3_Is_6")]
        [TestCase(new[] { 4, 1, 1, 1, 4 }, 16, TestName = "Grow_ProductOf_4_1_1_1_4_Is_16")]
        [TestCase(new[] { 2, 2, 2, 2, 2, 2 }, 64, TestName = "Grow_ProductOf_2x6_Is_64")]
        public void Grow_ShouldReturnCorrectProduct_WhenCalledWithValidArray(int[] elements, int expected)
        {
            // Act
            var actual = Kata.Grow(elements);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
