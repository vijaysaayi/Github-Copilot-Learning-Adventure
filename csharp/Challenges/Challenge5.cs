using System.Text.RegularExpressions;

namespace Challenges;

// Not sure what this regex is doing?  Ask Copilot to explain you.
public class Challenge5
{
    // Note: You need to add test cases for this method.
    public static bool SomeRandomCode(string input)
    {
        string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        // Check if input matches the regex pattern.
        return Regex.IsMatch(input, pattern);
    }
}