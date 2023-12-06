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
    [InlineData("Hello my number is +91-123-456-7890 and +91-987-654-3210", new[] { "+91-123-456-7890", "+91-987-654-3210" })]
    [InlineData("+91-123-456-7890,+91-987-654-3210 are two numbers", new[] { "+91-123-456-7890", "+91-987-654-3210" })]
    [InlineData("I have another number +91-111-222-3333 and +91-444-555-6666", new[] { "+91-111-222-3333", "+91-444-555-6666" })]
    [InlineData("Here are more numbers +91-777-888-9999 and +91-000-111-2222", new[] { "+91-777-888-9999", "+91-000-111-2222" })]
    [InlineData("This is an invalid number format 123-456-7890", new string[] { })]
    [InlineData("No numbers in this text", new string[] { })]
    [InlineData("Invalid number format +91-123-456-7890 and 987-654-3210", new[] { "+91-123-456-7890" })]
    [InlineData("Invalid number format +91-123-456-7890 and +91-987-654-3210", new[] { "+91-123-456-7890", "+91-987-654-3210" })]

    public void ExtractEmailAddressTests(string text, string[] expectedResults)
    {
        var emailAddresses = Challenge1.ExtractEmailAddress(text);
        Assert.Equal(expectedResults, emailAddresses);
    }
}
