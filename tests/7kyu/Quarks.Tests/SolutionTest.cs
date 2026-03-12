namespace Quarks.Tests;

using NUnit.Framework;

/// <summary>
/// Tests unitaires de la classe <see cref="Quark"/>.
/// Vérifie l'initialisation des propriétés et l'interaction entre quarks.
/// </summary>
[TestFixture]
public class QuarkTests
{
    /// <summary>
    /// Vérifie que les propriétés sont correctement initialisées
    /// et que l'interaction échange les couleurs.
    /// </summary>
    [Test]
    public void Quark_Should_Initialize_And_Interact_Correctly()
    {
        Quark q1 = new Quark("red", "up");
        Quark q2 = new Quark("blue", "strange");

        Assert.That(q1.Color, Is.EqualTo("red"));
        Assert.That(q2.Flavor, Is.EqualTo("strange"));

        double expectedBaryonNumber = 1 / 3d;
        Assert.That(q2.BaryonNumber, Is.EqualTo(expectedBaryonNumber));

        q1.Interact(q2);

        Assert.That(q1.Color, Is.EqualTo("blue"));
        Assert.That(q2.Color, Is.EqualTo("red"));
    }
}