
namespace Core.Tests;

public class ContainerTests
{
    [Fact]
    public void Add_IncreasesCount_And_ElementIsRetrievable()
    {
        var c = new Container<int>();

        c.Add(42);

        Assert.Equal(1, c.Count);
        Assert.True(c.TryGet(0, out var value));
        Assert.Equal(42, value);
    }

    [Fact]
    public void Items_IsReadOnlyView_NotMutableExternally()
    {
        var c = new Container<int>();
        c.Add(1);

        var snapshot = c.Content.ToList();
        snapshot.Add(2);

        Assert.Equal(1, c.Count);
    }
    [Fact]
    public void RemoveAt_RemovesCorrectElement_And_ShiftsIndexes()
    {
        var c = new Container<string>();
        c.Add("A");
        c.Add("B");
        c.Add("C");

        c.RemoveAt(1);

        Assert.Equal(2, c.Count);
        Assert.True(c.TryGet(1, out var value));
        Assert.Equal("C", value);
    }
}

