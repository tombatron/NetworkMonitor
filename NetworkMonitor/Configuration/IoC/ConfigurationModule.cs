using Autofac;

namespace NetworkMonitor.Configuration.IoC
{
    public class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultApplicationConfiguration>().As<IApplicationConfiguration>().SingleInstance();
        }
    }
}