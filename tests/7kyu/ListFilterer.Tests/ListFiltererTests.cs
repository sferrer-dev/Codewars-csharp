using ListFilterer;

namespace ListFilterer.Tests;

[TestFixture]
public class ListFiltererTests
{
    [Test, Order(1)]
    public void GetIntegersFromList_MixedValues_ShouldPass_1()
    {
        var list = new List<object>() { 1, 2, "a", "b" };
        var expected = new List<int>() { 1, 2 };
        var actual = ListFilterer.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(2)]
    public void GetIntegersFromList_MixedValues_ShouldPass_2()
    {
        var list = new List<object>() { 1, "a", "b", 0, 15 };
        var expected = new List<int>() { 1, 0, 15 };
        var actual = ListFilterer.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(3)]
    public void GetIntegersFromList_MixedValues_ShouldPass_3()
    {
        var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
        var expected = new List<int>() { 1, 2, 123 };
        var actual = ListFilterer.GetIntegersFromList(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(4)]
    public void GetIntegersFromList_MixedValues_ShouldPass_4()
    {
        var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
        var expected = new List<int>() { 1, 2, 123 };
        var actual = ListFilterer.GetIntegersFromListWithoutLink(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test, Order(5)]
    public void GetIntegersFromList_MixedValues_ShouldPass_5()
    {
        var list = new List<object>() { 1, 2, "a", "b" };
        var expected = new List<int>() { 1, 2 };
        var actual = ListFilterer.GetIntegersFromListWithoutLink(list);
        Assert.That(actual, Is.EqualTo(expected));
    }
}