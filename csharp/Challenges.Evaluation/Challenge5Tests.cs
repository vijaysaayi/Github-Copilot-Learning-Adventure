namespace Challenges.Evaluation;

public class Challenge5Tests
{
    [Theory]
    [InlineData("Test-Case-1 : Provide-some-input")]
    [InlineData("Test-Case-2 : Provide-some-input")]
    [InlineData("Test-Case-3 : Provide-some-input")]
    public void YouNeedToProvideTheInlineData(string input)
    {
        Assert.True(Challenge5.SomeRandomCode(input));
    }
}
