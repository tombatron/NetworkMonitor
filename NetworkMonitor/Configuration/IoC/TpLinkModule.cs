using Autofac;
using NetworkMonitor.Services;

namespace NetworkMonitor.Configuration.IoC
{
    public class TpLinkModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ITpLinkClientFactory>().As<DefaultTpLinkClientFactory>().SingleInstance();
        }
    }
}
