using System.Runtime.InteropServices;

namespace Challenges.Evaluation;

public class Challenge4Tests
{
    [Fact]
    public void SequenceGeneratorTest()
    {
        // Arrange

        // Act
        var result = Challenge4.GenerateAndDisplaySequence(10);

        // Assert
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
        Assert.Equal(1, result[2]);
        Assert.Equal(2, result[3]);
        Assert.Equal(3, result[4]);
        Assert.Equal(5, result[5]);
        Assert.Equal(8, result[6]);
        Assert.Equal(13, result[7]);
        Assert.Equal(21, result[8]);
        Assert.Equal(34, result[9]);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 5, 8 })]
    [InlineData(new int[] { 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 }, new int[] { 47, 50, 53, 56, 59 })]
    [InlineData(new int[] { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 }, new int[] { 62, 65, 68, 71, 74 })]
    public void ModifyTheArrayTest(int[] array, int[] expectedNewArray)
    {
        var result = Challenge4.ModifyTheArray(array);
        Assert.Equal(expectedNewArray, result);
    }
}
