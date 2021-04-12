using System.Threading;
using System.Threading.Tasks;
using MassTransitRabbitMQ.Transactions.Contracts;

namespace MassTransitRabbitMQ_PoC_Publisher.Services
{
    public interface IEventService
    {
        public Task Publish(ISampleEvent @event, CancellationToken cancellationToken);
    }
}