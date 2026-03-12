namespace L1SetAlarm;

/// <summary>
/// Contient une méthode utilitaire pour déterminer si une alarme doit être activée.
/// </summary>
public static class Kata
{
    /// <summary>
    /// Retourne vrai si l'utilisateur est employé et non en vacances ; sinon, retourne faux.
    /// </summary>
    /// <param name="employed">Indique si l'utilisateur est employé.</param>
    /// <param name="vacation">Indique si l'utilisateur est en vacances.</param>
    /// <returns>True si l'alarme doit être activée, sinon false.</returns>
    public static bool SetAlarm(bool employed, bool vacation)
    {
        return employed && !vacation;
    }
}
