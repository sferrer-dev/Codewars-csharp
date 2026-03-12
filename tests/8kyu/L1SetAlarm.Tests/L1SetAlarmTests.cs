namespace L1SetAlarm.Tests;

/// <summary>
/// Contient les tests unitaires de la méthode SetAlarm de la classe Kata.
/// </summary>
[TestFixture]
public class KataTests
{
    [TestCase(true, true, ExpectedResult = false)]
    [TestCase(false, true, ExpectedResult = false)]
    [TestCase(true, false, ExpectedResult = true)]
    [TestCase(false, false, ExpectedResult = false)]
    public bool SetAlarm_ShouldReturnExpectedResult(bool employed, bool vacation)
    {
        return Kata.SetAlarm(employed, vacation);
    }
}
