namespace NetworkMonitor.Configuration
{
    public interface IApplicationConfiguration
    {
        string RouterUsername { get; }

        string RouterPassword { get; }

        string RouterBaseUrl { get; }
    }
}