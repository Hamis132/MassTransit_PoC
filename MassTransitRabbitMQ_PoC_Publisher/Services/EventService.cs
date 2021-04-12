using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using MassTransitRabbitMQ.Transactions.Contracts;

namespace MassTransitRabbitMQ_PoC_Publisher.Services
{
    public class EventService : IEventService
    {
        private readonly IPublishEndpoint _endpoint;

        public EventService(IPublishEndpoint endpoint)
        {
            _endpoint = endpoint;
        }

        public async Task Publish(ISampleEvent @event, CancellationToken cancellationToken)
        {
            try
            {
                await _endpoint.Publish(@event, cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}