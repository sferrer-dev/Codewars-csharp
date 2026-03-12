namespace MovingZerosToTheEnd.Tests;

public class Tests
{
    [TestFixture]
    public class Sample_Test
    {
        [Test]
        [Order(1)]
        public void Test()
        {
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
            Assert.That(Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(expected));
        }
    }
}