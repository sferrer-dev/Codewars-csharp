namespace Quarks;

/// <summary>
/// Représente un quark avec une couleur, une saveur et un nombre baryonique constant.
/// Deux quarks peuvent interagir en échangeant leur couleur.
/// </summary>
public class Quark(string color, string flavor)
{
    public string Color { get; private set; } = color;
    public string Flavor { get; } = flavor;
    public double BaryonNumber => 1d / 3d;

    public void Interact(Quark other) =>
        (Color, other.Color) = (other.Color, Color);
}