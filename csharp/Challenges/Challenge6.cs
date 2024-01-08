
namespace Challenges;

public static class Challenge6
{
    // Goal : Implement retry logic using copilot.
    public static int GetCpuUsageOfApiWithRetry()
    {
        return GetCPUUsageOfApi();
    }

    // Note: Do not modify this method.
    // This is a stimulation for BUGGY endpoint.
    private static int GetCPUUsageOfApi()
    {
        var random = new Random();
        var cpuUsage = random.Next(-1, 1);
        
        if (cpuUsage != 1)
        {
            throw new Exception("Failed to get CPU usage");
        }

        return cpuUsage * 73;
    }
}
