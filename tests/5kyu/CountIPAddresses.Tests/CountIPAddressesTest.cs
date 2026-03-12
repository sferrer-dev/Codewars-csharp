namespace CountIPAddresses.Tests;

/// <summary>
/// Tests unitaires de la classe <see cref="CountIPAddresses"/>.
/// </summary>
[TestFixture]
public class CountIPAddressesTests
{
    /// <summary>
    /// Vérifie le calcul du nombre d'adresses IP entre deux adresses.
    /// </summary>
    [Test]
    public void SampleTest()
    {
        Assert.That(CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"), Is.EqualTo(50));
        Assert.That(CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"), Is.EqualTo(246));
        Assert.That(CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"), Is.EqualTo((1L << 32) - 1L));
    }
}