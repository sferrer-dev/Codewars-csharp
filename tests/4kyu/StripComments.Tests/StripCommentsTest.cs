public class StripCommentsTest
{
    [Test]
    public void StripComments()
    {
        Assert.That(StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }),
            Is.EqualTo("apples, pears\ngrapes\nbananas"));

        Assert.That(StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }),
            Is.EqualTo("a\nc\nd"));
    }
}