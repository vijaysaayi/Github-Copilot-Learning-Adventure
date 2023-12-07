namespace Challenges.Evaluation;

public class Challenge1Tests
{
    [Theory]
    [InlineData("This is a valid number format +1-123-456-7890 and +1-987-654-3210", new[] { "+1-123-456-7890", "+1-987-654-3210" })]
    [InlineData("Invalid number format 123-456-7890 and 987-654-3210", new string[] { })]
    [InlineData("No numbers in this text", new string[] { })]
    public void ExtractPhoneNumbersTests(string text, string[] expectedResults)
    {
        var phoneNumbers = Challenge1.ExtractPhoneNumbers(text);
        Assert.Equal(expectedResults, phoneNumbers);
    }

    [Theory]
    [InlineData("This is a valid email address test@example.com and another one test2@example.com", new[] { "test@example.com", "test2@example.com" })]
    [InlineData("Invalid email address format test@example and test2@example", new string[] { })]
    [InlineData("No email addresses in this text", new string[] { })]
    public void ExtractEmailAddressTests(string text, string[] expectedResults)
    {
        var emailAddresses = Challenge1.ExtractEmailAddress(text);
        Assert.Equal(expectedResults, emailAddresses);
    }
}
