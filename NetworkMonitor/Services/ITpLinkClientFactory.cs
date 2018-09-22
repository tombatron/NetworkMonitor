using TpLinkSharp;

namespace NetworkMonitor.Services
{
    public interface ITpLinkClientFactory
    {
        TpLinkClient CreateClient();
    }
}
