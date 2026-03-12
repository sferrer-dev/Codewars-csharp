using NUnit.Framework;

namespace HowGoodAreYouReally.Tests
{
    /// <summary>
    /// Classe de tests unitaires pour la méthode <see cref="Kata.BetterThanAverage"/>.
    /// </summary>
    [TestFixture]
    public class HowGoodAreYouReallyTests
    {
        /// <summary>
        /// Exécute un test unitaire sur la méthode BetterThanAverage avec les valeurs spécifiées.
        /// </summary>
        /// <param name="classGrades">Tableau des notes de la classe.</param>
        /// <param name="userGrade">Note de l'utilisateur.</param>
        /// <param name="expected">Résultat attendu.</param>
        private static void AssertBetterThanAverage(int[] classGrades, int userGrade, bool expected)
        {
            // Construction d’un message explicite pour aider au débogage en cas d’échec du test
            var message = $"Note de l'utilisateur : {userGrade} | Notes de la classe : [{string.Join(", ", classGrades)}]";
            var result = Kata.BetterThanAverage(classGrades, userGrade);
            Assert.That(result, Is.EqualTo(expected), message);
        }

        /// <summary>
        /// Vérifie si la note de l'utilisateur est supérieure à la moyenne de la classe.
        /// </summary>
        /// <param name="userGrade">Note de l'utilisateur à tester.</param>
        /// <param name="expected">Résultat attendu (true si supérieur à la moyenne).</param>
        /// <param name="classGrades">Tableau des notes de la classe.</param>
        [TestCase(5, true, new[] { 2, 3 })]
        [TestCase(75, true, new[] { 100, 40, 34, 57, 29, 72, 57, 88 })]
        [TestCase(69, true, new[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 })]
        [TestCase(11, false, new[] { 100, 90 })]
        public void Should_Return_Expected_Result(int userGrade, bool expected, int[] classGrades)
        {
            // Construction d’un message d’aide à la lecture en cas d’échec
            var message = $"Note utilisateur : {userGrade} | Notes classe : [{string.Join(", ", classGrades)}]";
            var actual = Kata.BetterThanAverage(classGrades, userGrade);

            Assert.That(actual, Is.EqualTo(expected), message);
        }
    }
}
