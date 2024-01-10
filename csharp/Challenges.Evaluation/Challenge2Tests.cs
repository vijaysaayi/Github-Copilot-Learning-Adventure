namespace Challenges.Evaluation;

public class Challenge2Tests
{
    [Theory]
    [InlineData("#FF0000", 255, 0, 0)]
    [InlineData("#00FF00", 0, 255, 0)]
    [InlineData("#0000FF", 0, 0, 255)]
    [InlineData("#FFFFFF", 255, 255, 255)]
    public void ConvertHexToRGBColorValueTests(string hexValue, int expectedRed, int expectedGreen, int expectedBlue)
    {
        var (red, green, blue) = Challenge2.ConvertHexToRGBColorValue(hexValue);
        Assert.Equal(expectedRed, red);
        Assert.Equal(expectedGreen, green);
        Assert.Equal(expectedBlue, blue);
    }

    [Theory]
    [InlineData(255, 0, 0, "#FF0000")]
    [InlineData(0, 255, 0, "#00FF00")]
    [InlineData(0, 0, 255, "#0000FF")]
    [InlineData(255, 255, 255, "#FFFFFF")]
    public void ConvertRGBColorValueToHexTests(int red, int green, int blue, string expectedHexValue)
    {
        var hexValue = Challenge2.ConvertRGBColorValueToHex(red, green, blue);
        Assert.Equal(expectedHexValue, hexValue);
    }
}
