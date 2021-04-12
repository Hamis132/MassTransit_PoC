using MassTransit;
using MassTransitRabbitMQ_PoC_Publisher.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MassTransitRabbitMQ_PoC_Publisher.Extensions
{
    public static class QueueExtension
    {
        public static IServiceCollection RegisterQueueServices(this IServiceCollection services, IConfiguration section)
        {
            var queueSettingsSection = section.GetSection("QueueSettings");
            var queueSettings = queueSettingsSection.Get<QueueSettings>();

            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host(queueSettings.HostName, queueSettings.VirtualHost, h =>
                    {
                        h.Username(queueSettings.UserNamed);
                        h.Password(queueSettings.Password);
                    });
                });
            });
            services.AddMassTransitHostedService();

            return services;
        }
    }
}