using NetworkMonitor.Configuration;
using TpLinkSharp;

namespace NetworkMonitor.Services
{
    public class DefaultTpLinkClientFactory : ITpLinkClientFactory
    {
        private readonly IApplicationConfiguration _configuration;

        public DefaultTpLinkClientFactory(IApplicationConfiguration configuration) =>
            _configuration = configuration;

        public TpLinkClient CreateClient()
        {
            var client = new TpLinkClient(_configuration.RouterBaseUrl);

            client.Connect(_configuration.RouterUsername, _configuration.RouterPassword);

            return client;
        }
    }
}