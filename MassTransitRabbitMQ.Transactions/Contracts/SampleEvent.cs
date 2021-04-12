using System;

namespace MassTransitRabbitMQ.Transactions.Contracts
{
    public class SampleEvent : ISampleEvent
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}