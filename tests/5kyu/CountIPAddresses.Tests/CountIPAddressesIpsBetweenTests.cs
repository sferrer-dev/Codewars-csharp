namespace CountIPAddresses.Tests;

/// <summary>
/// Tests unitaires vérifiant le comportement de la méthode
/// <see cref="CountIPAddresses.IpsBetween(string, string)"/>.
/// </summary>
[TestFixture]
public class CountIPAddressesIpsBetweenTests
{
    /// <summary>
    /// Vérifie que la méthode retourne le nombre correct
    /// d'adresses IP lorsque les adresses diffèrent uniquement
    /// sur le dernier octet.
    /// </summary>
    [Test]
    public void IpsBetween_Should_Return_Correct_Count_When_Only_Last_Octet_Differs()
    {
        long result = CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50");

        Assert.That(result, Is.EqualTo(50));
    }

    /// <summary>
    /// Vérifie que la méthode calcule correctement le nombre
    /// d'adresses IP lorsque l'écart traverse un sous-réseau.
    /// </summary>
    [Test]
    public void IpsBetween_Should_Return_Correct_Count_When_Crossing_Subnet()
    {
        long result = CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0");

        Assert.That(result, Is.EqualTo(246));
    }

    /// <summary>
    /// Vérifie que la méthode gère correctement l'intervalle
    /// maximal possible entre deux adresses IPv4.
    /// </summary>
    [Test]
    public void IpsBetween_Should_Handle_Maximum_IPv4_Range()
    {
        long result = CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255");

        Assert.That(result, Is.EqualTo((1L << 32) - 1L));
    }

    /// <summary>
    /// Vérifie plusieurs scénarios représentatifs
    /// à l'aide de tests paramétrés.
    /// </summary>
    [TestCase("10.0.0.0", "10.0.0.1", 1)]
    [TestCase("10.0.0.0", "10.0.1.0", 256)]
    [TestCase("192.168.0.0", "192.168.1.0", 256)]
    public void IpsBetween_Should_Return_Expected_Value(string start, string end, long expected)
    {
        long result = CountIPAddresses.IpsBetween(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }
}