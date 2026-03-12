namespace StripComments.Tests;

[TestFixture]
public class StripCommentsSolutionTests
{
    [Test]
    public void StripComments_Should_Match_Codewars_Sample_1()
    {
        // Arrange
        // Texte multi-lignes avec deux marqueurs de commentaires : '#' et '!'.
        // Règle attendue : tout ce qui suit un marqueur sur une ligne est supprimé,
        // puis les espaces en fin de ligne sont retirés.
        var input = "apples, pears # and bananas\ngrapes\nbananas !apples";
        var markers = new[] { "#", "!" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // - Ligne 1 : "apples, pears # and bananas" -> "apples, pears"
        // - Ligne 2 : "grapes" -> inchangée
        // - Ligne 3 : "bananas !apples" -> "bananas"
        Assert.That(result, Is.EqualTo("apples, pears\ngrapes\nbananas"));
    }

    [Test]
    public void StripComments_Should_Match_Codewars_Sample_2()
    {
        // Arrange
        // Second exemple officiel : deux marqueurs '#' et '$'.
        var input = "a #b\nc\nd $e f g";
        var markers = new[] { "#", "$" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // - "a #b" -> "a"
        // - "c" -> "c"
        // - "d $e f g" -> "d"
        Assert.That(result, Is.EqualTo("a\nc\nd"));
    }

    [Test]
    public void StripComments_Should_Trim_End_Of_Line_Even_When_No_Marker_Is_Present()
    {
        // Arrange
        // Ici, aucun marqueur n'est utilisé : on teste uniquement la règle
        // "tout espace blanc en fin de ligne doit être supprimé".
        var input = "abc   \nxyz\t\t";
        var markers = Array.Empty<string>();

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // Les espaces et tabulations en fin de ligne sont supprimés.
        Assert.That(result, Is.EqualTo("abc\nxyz"));
    }

    [Test]
    public void StripComments_Should_Cut_Using_The_Leftmost_Marker_Not_The_First_In_The_Array()
    {
        // Arrange
        // On vérifie que l'algorithme coupe au marqueur le plus à gauche dans la ligne.
        // Ici '#' apparaît avant '!' dans la ligne, même si '!' est en première position du tableau.
        var input = "a #b !c";
        var markers = new[] { "!", "#" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // La coupe se fait à '#', donc il ne reste que "a" (avec TrimEnd).
        Assert.That(result, Is.EqualTo("a"));
    }

    [Test]
    public void StripComments_Marker_At_Start_Of_Line_Should_Return_Empty_Line()
    {
        // Arrange
        // Cas limite : le marqueur est le premier caractère de la ligne.
        // La partie "avant commentaire" est donc vide.
        var input = "#comment\nvalue";
        var markers = new[] { "#", "!" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // La première ligne devient vide, mais le saut de ligne est conservé.
        Assert.That(result, Is.EqualTo("\nvalue"));
    }

    [Test]
    public void StripComments_Should_Preserve_Empty_Lines_And_Trailing_Newline()
    {
        // Arrange
        // Ce test sécurise deux points :
        // 1) Les lignes vides intermédiaires doivent être conservées.
        // 2) Un '\n' final dans l'entrée doit produire une ligne vide finale dans la sortie.
        var input = "a\n\nb #c\n";
        var markers = new[] { "#" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // Split('\n') sur "a\n\nb #c\n" produit 4 lignes : "a", "", "b #c", ""
        // Après nettoyage : "a", "", "b", "" => "a\n\nb\n"
        Assert.That(result, Is.EqualTo("a\n\nb\n"));
    }

    [Test]
    public void StripComments_Should_Handle_Windows_CRLF_By_Removing_Trailing_CarriageReturn()
    {
        // Arrange
        // Entrée en format Windows "\r\n".
        // Après Split('\n'), chaque ligne (sauf la dernière) finit par '\r' et doit être normalisée.
        var input = "a #b\r\nc\r\nd $e\r\n";
        var markers = new[] { "#", "$" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // Le kata attend une sortie normalisée en '\n' (car on split/join sur '\n').
        Assert.That(result, Is.EqualTo("a\nc\nd\n"));
    }

    [Test]
    public void StripComments_Should_Ignore_Null_Or_Empty_Markers_Defensively()
    {
        // Arrange
        // Certains environnements / usages peuvent fournir des marqueurs invalides.
        // Notre implémentation les ignore pour éviter IndexOf(null) (qui lancerait une exception).
        var input = "a #b\nc";
        var markers = new string[] { "", null!, "#" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        // Seul '#' est considéré comme valide.
        Assert.That(result, Is.EqualTo("a\nc"));
    }

    [Test]
    public void StripComments_Null_Text_Should_Throw_ArgumentNullException()
    {
        // Arrange / Act / Assert
        // Garde-fou : une entrée null doit lever une exception explicite.
        Assert.That(
            () => StripCommentsSolution.StripComments(null!, new[] { "#" }),
            Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void StripComments_Null_Markers_Should_Throw_ArgumentNullException()
    {
        // Arrange / Act / Assert
        // Garde-fou : le tableau de marqueurs ne peut pas être null.
        Assert.That(
            () => StripCommentsSolution.StripComments("abc", null!),
            Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void StripComments_MultiCharacter_Marker_Should_Work()
    {
        // Arrange
        // Certains marqueurs peuvent être multi-caractères (ex: "//" ou "--").
        // IndexOf(string) supporte nativement ce cas.
        var input = "alpha //-- comment\nbeta";
        var markers = new[] { "//--" };

        // Act
        var result = StripCommentsSolution.StripComments(input, markers);

        // Assert
        Assert.That(result, Is.EqualTo("alpha\nbeta"));
    }
}