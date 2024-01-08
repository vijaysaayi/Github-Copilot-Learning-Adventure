namespace Challenges.Evaluation;

public class Challenge1Tests
{
    [Theory]
    [InlineData("Today is 2024-01-11T11:25:00Z", new string[] { "2024-01-11T11:25:00Z" })]
    [InlineData("Today is 2024-01-11T11:25:00Z and tomorrow is 2024-01-12T11:25:00Z", new string[] { "2024-01-11T11:25:00Z", "2024-01-12T11:25:00Z" })]
    [InlineData("Today is 2024-01-11T11:25:00Z and tomorrow is 2024-01-12T11:25:00Z and yesterday was 2024-01-10T11:25:00Z", new string[] { "2024-01-11T11:25:00Z", "2024-01-12T11:25:00Z", "2024-01-10T11:25:00Z" })]
    [InlineData("Today is 2024-01-11 11:25:00 ", new string[] { })]
    public void ExtractDateTimeTests(string text, string[] expectedResults)
    {
        var dateAndTime = Challenge1.ExtractDateTime(text);
        Assert.Equal(expectedResults, dateAndTime);
    }

    [Theory]
    [InlineData("My client IP is 10.0.0.2", new string[] { "10.0.0.2" })]
    [InlineData("Machine with IP is 192.168.0.5 was able to connect to 200.0.0.4", new string[] { "192.168.0.5", "200.0.0.4" })]
    [InlineData("My Ip address range is is 10.0.0.0/27", new string[] { "10.0.0.0/27" })]
    public void ExtractIpAddressTests(string text, string[] expectedResults)
    {
        var ipAddress = Challenge1.ExtractIpAddress(text);
        Assert.Equal(expectedResults, ipAddress);
    }
}
