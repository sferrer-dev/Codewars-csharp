namespace ProdFib.Tests;

/// <summary>
/// Vérifie le comportement de la méthode <see cref="ProdFib.productFib(ulong)"/>.
/// </summary>
[TestFixture]
public sealed class ProdFibTests
{
    /// <summary>
    /// Vérifie que la méthode retourne le couple exact
    /// lorsque le produit correspond à deux nombres de Fibonacci consécutifs.
    /// </summary>
    [TestCase(4895UL, 55UL, 89UL, 1UL)]
    [TestCase(5895UL, 89UL, 144UL, 0UL)]
    [TestCase(74049690UL, 6765UL, 10946UL, 1UL)]
    [TestCase(84049690UL, 10946UL, 17711UL, 0UL)]
    [TestCase(193864606UL, 10946UL, 17711UL, 1UL)]
    [TestCase(447577UL, 610UL, 987UL, 0UL)]
    [TestCase(602070UL, 610UL, 987UL, 1UL)]
    public void ProductFib_Should_Return_Expected_Fibonacci_Pair_And_Exact_Flag(
        ulong prod,
        ulong expectedFirst,
        ulong expectedSecond,
        ulong expectedFlag)
    {
        // Arrange
        ulong[] expected = [expectedFirst, expectedSecond, expectedFlag];

        // Act
        ulong[] actual = ProdFib.productFib(prod);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie le comportement sur le premier cas trivial :
    /// le produit 0 correspond au couple Fibonacci (0, 1).
    /// </summary>
    [Test]
    public void ProductFib_Should_Return_Zero_One_And_Exact_Flag_When_Product_Is_Zero()
    {
        // Arrange
        ulong[] expected = [0UL, 1UL, 1UL];

        // Act
        ulong[] actual = ProdFib.productFib(0UL);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que la méthode retourne le premier couple
    /// dont le produit dépasse la valeur cible lorsque
    /// aucun produit exact n'existe.
    /// </summary>
    [Test]
    public void ProductFib_Should_Return_First_Greater_Consecutive_Fibonacci_Product_When_No_Exact_Match_Exists()
    {
        // Arrange
        const ulong prod = 800UL;
        ulong[] expected = [34UL, 55UL, 0UL]; // 34 * 55 = 1870 > 800, après 21 * 34 = 714

        // Act
        ulong[] actual = ProdFib.productFib(prod);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Vérifie que le tableau retourné contient toujours exactement
    /// trois valeurs : F(n), F(n+1) et le drapeau d'exactitude.
    /// </summary>
    [Test]
    public void ProductFib_Should_Always_Return_Array_With_Three_Elements()
    {
        // Act
        ulong[] actual = ProdFib.productFib(4895UL);

        // Assert
        Assert.That(actual, Has.Length.EqualTo(3));
    }

    /// <summary>
    /// Vérifie que les deux premières valeurs retournées
    /// sont bien deux nombres de Fibonacci consécutifs.
    /// </summary>
    [TestCase(4895UL)]
    [TestCase(5895UL)]
    [TestCase(74049690UL)]
    [TestCase(84049690UL)]
    public void ProductFib_Should_Return_Consecutive_Fibonacci_Numbers(ulong prod)
    {
        // Act
        ulong[] actual = ProdFib.productFib(prod);

        // Assert
        Assert.That(actual[0] + actual[1], Is.GreaterThan(actual[1])); // simple garde sur l'évolution positive
        Assert.That(IsNextFibonacci(actual[0], actual[1]), Is.True);
    }

    /// <summary>
    /// Vérifie que le drapeau vaut 1 uniquement lorsque
    /// le produit des deux nombres retournés est exactement égal à la cible.
    /// </summary>
    [TestCase(4895UL, 1UL)]
    [TestCase(5895UL, 0UL)]
    [TestCase(74049690UL, 1UL)]
    [TestCase(84049690UL, 0UL)]
    public void ProductFib_Should_Set_Exact_Flag_Correctly(ulong prod, ulong expectedFlag)
    {
        // Act
        ulong[] actual = ProdFib.productFib(prod);
        ulong actualFlag = actual[2];
        ulong computedFlag = actual[0] * actual[1] == prod ? 1UL : 0UL;

        // Assert
        Assert.That(actualFlag, Is.EqualTo(expectedFlag));
        Assert.That(actualFlag, Is.EqualTo(computedFlag));
    }

    /// <summary>
    /// Vérifie si <paramref name="second"/> est bien le nombre de Fibonacci
    /// suivant immédiatement <paramref name="first"/>.
    /// </summary>
    /// <param name="first">Premier nombre de Fibonacci.</param>
    /// <param name="second">Nombre supposé être le suivant.</param>
    /// <returns>
    /// <see langword="true"/> si les deux nombres sont consécutifs dans la suite de Fibonacci ;
    /// sinon, <see langword="false"/>.
    /// </returns>
    private static bool IsNextFibonacci(ulong first, ulong second)
    {
        ulong a = 0;
        ulong b = 1;

        while (a < first)
        {
            (a, b) = (b, a + b);
        }

        return a == first && b == second;
    }
}
