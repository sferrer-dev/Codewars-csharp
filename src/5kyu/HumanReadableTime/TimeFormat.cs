namespace HumanReadableTime;

/// <summary>
/// Fournit une méthode utilitaire permettant de convertir
/// un nombre de secondes en une représentation temporelle
/// lisible par un humain au format HH:MM:SS.
/// </summary>
public static class TimeFormat
{
    /// <summary>
    /// Convertit un nombre de secondes en une chaîne formatée
    /// au format "HH:MM:SS".
    /// </summary>
    /// <param name="seconds">
    /// Nombre total de secondes (valeur comprise entre 0 et 359999).
    /// </param>
    /// <returns>
    /// Une chaîne représentant le temps sous la forme HH:MM:SS.
    /// </returns>
    public static string GetReadableTime(int seconds)
    {
        // Calcul du nombre d'heures complètes
        int hours = seconds / 3600;

        // Calcul des minutes restantes après extraction des heures
        int minutes = (seconds % 3600) / 60;

        // Calcul des secondes restantes
        int secs = seconds % 60;

        // Formatage avec deux chiffres (padding automatique avec '0')
        return $"{hours:D2}:{minutes:D2}:{secs:D2}";
    }
    /// <summary>
    /// Convertit un nombre de secondes en une chaîne formatée
    /// au format "HH:MM:SS".
    /// </summary>
    /// <param name="seconds">
    /// Nombre total de secondes compris entre 0 et 359999.
    /// </param>
    /// <returns>
    /// Une chaîne représentant le temps au format HH:MM:SS.
    /// </returns>
    public static string GetReadableTimeV2(int seconds)
    {
        // Création d'un objet TimeSpan représentant la durée donnée.
        TimeSpan time = TimeSpan.FromSeconds(seconds);

        // TimeSpan fournit directement les heures, minutes et secondes.
        // Attention : on utilise TotalHours pour gérer correctement
        // les valeurs supérieures à 24h (ex: 99:59:59 dans ce kata).
        int hours = (int)time.TotalHours;
        int minutes = time.Minutes;
        int secs = time.Seconds;

        // Formatage avec deux chiffres pour chaque unité temporelle.
        return $"{hours:D2}:{minutes:D2}:{secs:D2}";
    }
}