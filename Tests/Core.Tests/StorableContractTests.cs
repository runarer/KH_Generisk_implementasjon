using Core;

public class StorableContractTests
{
    [Fact]
    public void Save_Then_TryLoad_ReturnsSavedItem()
    {
        IStorable<string> s = new Container<String>();

        s.Add("hello");
        var ok = s.TryGet(0,out var value);

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
}

