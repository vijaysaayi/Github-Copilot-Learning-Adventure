using System.Runtime.InteropServices;

namespace Challenges.Evaluation;

public class Challenge4Tests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5)]
    public void GetSquares_ReturnsCorrectResult(int n)
    {
        // Arrange

        // Act
        var result = Challenge4.GetSquares();

        // Assert
        Assert.Equal(n * n, result[n]);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5)]
    public void YRangeTest(int n)
    {
        // Arrange

        // Act
        var result = Challenge4.YRange(n);

        // Assert
        Assert.Equal(n, result.Length);
    }
}
