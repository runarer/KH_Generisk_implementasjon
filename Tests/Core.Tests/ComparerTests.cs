
public class ComparerTests
{
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 1, 1)]
    [InlineData(5, 5, 0)]
    public void Compare_Ints_ReturnsExpectedOrder(int a, int b, int expected)
    {
        var cmp = new Core.Comparer<int>();

        var result = cmp.Compare(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("aab", "aabb", -1)]
    [InlineData("", "aabb", -1)]
    [InlineData("", "", 0)]
    [InlineData("ab", "ab", 0)]
    [InlineData("Abe", "A43ee", 1)]
    [InlineData("Abe", "", 1)]
    public void Compare_Strings_ReturnsExpectedOrder(string a, string b, int expected)
    {
        var cmp = new Core.Comparer<string>();

        var result = cmp.Compare(a, b);

        Assert.Equal(expected, result);
    }
}