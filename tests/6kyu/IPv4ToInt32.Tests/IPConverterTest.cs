namespace IPv4ToInt32.Tests;

/// <summary>
/// Tests unitaires vérifiant la conversion
/// d'adresses IPv4 en entier 32 bits.
/// </summary>
[TestFixture]
public class IPv4ToInt32Tests
{
    /// <summary>
    /// Vérifie la conversion d'une adresse IPv4 connue.
    /// </summary>
    [Test]
    public void ToInt32_ShouldConvertIPv4ToUInt32()
    {
        uint result = IPConvert.ToInt32("128.32.10.1");

        Assert.That(result, Is.EqualTo(2149583361),
            "Incorrect answer for ip = \"128.32.10.1\"");
    }
}
