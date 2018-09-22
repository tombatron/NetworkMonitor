using System;

namespace NetworkMonitor.Configuration
{
    public class DefaultApplicationConfiguration : IApplicationConfiguration
    {
        private const string RouterUsernameEnvVariable = "ROUTER_USERNAME";
        private const string RouterPasswordEnvVariable = "ROUTER_PASSWORD";

        private readonly string _routerUsername;
        private readonly string _routerPassword;

        public DefaultApplicationConfiguration()
        {
            _routerUsername = Environment.GetEnvironmentVariable(RouterUsernameEnvVariable);
            _routerPassword = Environment.GetEnvironmentVariable(RouterPasswordEnvVariable);
        }

        public string RouterUsername => _routerUsername;
        public string RouterPassword => _routerPassword;
        public string RouterBaseUrl => "http://192.168.0.1";
    }
}