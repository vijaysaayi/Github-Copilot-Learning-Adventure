namespace Challenges.Evaluation;

public class Challenge6Tests
{
    [Fact]
    public async Task GetCpuUsageWithRetryTests()
    {
        for (int i = 0; i < 5; i++)
        {
            Challenge6.GetCpuUsageOfApiWithRetry();

            await Task.Delay(500);
        }        
    }
}
