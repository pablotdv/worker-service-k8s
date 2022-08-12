using Microsoft.Extensions.Diagnostics.HealthChecks;

public class CustomHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
        CancellationToken cancellationToken = new CancellationToken())
    {
        return Task.FromResult(new HealthCheckResult(HealthStatus.Healthy));
    }
}