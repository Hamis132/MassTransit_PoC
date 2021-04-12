using System;
using System.Threading.Tasks;
using MassTransit;
using MassTransitRabbitMQ.Transactions.Contracts;

namespace MassTransitRabbitMQ_PoC_Consumer.Consumers
{
    public class EventConsumer : IConsumer<ISampleEvent>
    {
        public async Task Consume(ConsumeContext<ISampleEvent> context)
        {
            //await context.Publish<ISampleEvent>(context.Message);
            Console.WriteLine(
                $"ID:{context.Message.Id}\nDescription: {context.Message.Description}\nCreationDate: {context.Message.CreationDate.ToShortDateString()}");
        }
    }
}