namespace Challenges.Evaluation;

public class Challenge5Tests
{
    // Goal : What should be the input so that this test case passes ?
    [Theory]
    [InlineData("Provide-some-input")]
    [InlineData("Provide-some-input")]
    [InlineData("Provide-some-input")]
    public void YouNeedToProvideTheInlineData(string input)
    {
        Assert.True(Challenge5.SomeRandomCode(input));
    }
}
