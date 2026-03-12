namespace StringsMix.Tests;

/// <summary>
/// Tests unitaires pour la méthode <see cref="Mixing.Mix(string, string)"/>.
/// 
/// Ces tests vérifient la comparaison des fréquences de lettres
/// entre deux chaînes et la construction correcte de la chaîne résultat.
/// </summary>
[TestFixture]
public class MixingTests
{
    /// <summary>
    /// Vérifie que la méthode Mix retourne la représentation correcte
    /// lorsque la deuxième chaîne possède davantage d'occurrences.
    /// </summary>
    [Test]
    public void Mix_Should_ReturnExpectedResult_When_SecondStringHasMoreOccurrences()
    {
        string s1 = "Are they here";
        string s2 = "yes, they are here";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo("2:eeeee/2:yy/=:hh/=:rr"));
    }

    /// <summary>
    /// Vérifie la construction correcte du résultat avec plusieurs lettres
    /// dominantes et un tri multi-critères.
    /// </summary>
    [Test]
    public void Mix_Should_ReturnCorrectOrdering_When_MultipleLettersHaveDifferentFrequencies()
    {
        string s1 = "looping is fun but dangerous";
        string s2 = "less dangerous than coding";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg"));
    }

    /// <summary>
    /// Vérifie que la méthode gère correctement des lettres présentes
    /// uniquement dans l'une des deux chaînes.
    /// </summary>
    [Test]
    public void Mix_Should_ReturnExpectedResult_When_LettersAppearInOnlyOneString()
    {
        string s1 = " In many languages";
        string s2 = " there's a pair of functions";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt"));
    }

    /// <summary>
    /// Vérifie que la méthode ignore correctement les caractères non pertinents
    /// et ne conserve que les lettres minuscules apparaissant plus d'une fois.
    /// </summary>
    [Test]
    public void Mix_Should_IgnoreUppercaseAndSingleOccurrences()
    {
        string s1 = "Lords of the Fallen";
        string s2 = "gamekult";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo("1:ee/1:ll/1:oo"));
    }

    /// <summary>
    /// Vérifie que la méthode retourne une chaîne vide
    /// lorsque les deux chaînes ont exactement les mêmes fréquences.
    /// </summary>
    [Test]
    public void Mix_Should_ReturnEmptyString_When_StringsHaveSameFrequencies()
    {
        string s1 = "codewars";
        string s2 = "codewars";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo(""));
    }

    /// <summary>
    /// Vérifie le cas où la première chaîne possède davantage d'occurrences
    /// pour plusieurs lettres.
    /// </summary>
    [Test]
    public void Mix_Should_ReturnExpectedResult_When_FirstStringHasMoreOccurrences()
    {
        string s1 = "A generation must confront the looming ";
        string s2 = "codewarrs";

        string result = Mixing.Mix(s1, s2);

        Assert.That(result, Is.EqualTo("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr"));
    }
}