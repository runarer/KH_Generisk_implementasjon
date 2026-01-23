using Core;
public class IContainerContractTests
{
    [Fact]
    public void RemoveAt_RemovesCorrectElement_AndShiftsNextElement()
    {
        var c = new Container<string>();
        c.Add("A");
        c.Add("B");
        c.Add("C");

        c.RemoveAt(1);

        Assert.True(c.TryGet(1, out var value));
        Assert.Equal("C", value);
    }

    [Fact]
    public void TryGet_AddsItemTheTryToRetiveItem_ReturnsSavedItem()
    {
        IContainer<string> c = new Container<string>();

        c.Add("hello");
        var ok = c.TryGet(0, out var value);

        Assert.True(ok);
        Assert.Equal("hello", value);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(999)]
    public void TryGet_OutOfRange_ReturnsFalse(int index)
    {
        var c = new Container<double>();
        c.Add(1.0);

        var ok = c.TryGet(index, out var _);

        Assert.False(ok);
    }

    [Fact]
    public void TryGetLast_AddsTwoElements_ReturnsLastElementAndTrue()
    {
        var c = new Container<string>();
        string zero = "Index Zero";
        string one = "Index One";
        c.Add(zero);
        c.Add(one);

        bool ok = c.TryGetLast(out string? result);

        Assert.True(ok);
        Assert.Equal(one, result);
    }

    [Fact]
    public void TryGetLast_NoElementsInStorage_ReturnsFalse()
    {
        var c = new Container<string>();

        bool ok = c.TryGetLast(out string? _);

        Assert.False(ok);
    }

    [Fact]
    public void TryGetFirst_AddsTwoElements_ReturnsFirstElementAndTrue()
    {
        var c = new Container<string>();
        string zero = "Index Zero";
        string one = "Index One";
        c.Add(zero);
        c.Add(one);

        bool ok = c.TryGetFirst(out string? result);

        Assert.True(ok);
        Assert.Equal(zero, result);
    }

    [Fact]
    public void TryGetFirst_NoElementsInStorage_ReturnsFalse()
    {
        var c = new Container<string>();

        bool ok = c.TryGetFirst(out string? _);

        Assert.False(ok);
    }
}

