namespace Challenges.Evaluation;

public class Challenge2Tests
{
    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 100)]
    [InlineData(120, 100, 50, 100, 0, 100, 0)]
    [InlineData(240, 100, 50, 100, 100, 0, 0)]
    [InlineData(60, 100, 50, 0, 0, 100, 0)]
    [InlineData(180, 100, 50, 0, 100, 100, 0)]
    public void ConvertHSLToCMYKTests(int hue, int saturation, int lightness,
                                      int expectedCyan, int expectedMegenta, int expectedYellow, int expectedKey)
    {
        var (cyan, magenta, yellow, key) = Challenge2.ConvertHSLToCMYK(hue, saturation, lightness);
        Assert.Equal(expectedCyan, cyan);
        Assert.Equal(expectedMegenta, magenta);
        Assert.Equal(expectedYellow, yellow);
        Assert.Equal(expectedKey, key);
    }

    [Theory]
    [InlineData(0, 0, 0, 0, 0, 0, 0)]
    [InlineData(100, 0, 0, 0, 240, 100, 50)]
    [InlineData(0, 100, 0, 0, 120, 100, 50)]
    [InlineData(0, 0, 100, 0, 60, 100, 50)]
    [InlineData(100, 100, 100, 0, 180, 100, 50)]
    public void ConvertCMYKToHSLTests(int cyan, int magenta, int yellow, int key,
                                             int expectedHue, int expectedSaturation, int expectedLightness)
    {
        var (hue, saturation, lightness) = Challenge2.ConvertCMYKToHSL(cyan, magenta, yellow, key);
        Assert.Equal(expectedHue, hue);
        Assert.Equal(expectedSaturation, saturation);
        Assert.Equal(expectedLightness, lightness);
    }
}
