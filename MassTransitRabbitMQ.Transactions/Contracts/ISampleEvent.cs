using System;
using System.Runtime.CompilerServices;
using MassTransit;
using MassTransit.Topology.Topologies;

namespace MassTransitRabbitMQ.Transactions.Contracts
{
    public interface ISampleEvent
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        [ModuleInitializer]
        internal static void Init()
        {
            GlobalTopology.Send.UseCorrelationId<ISampleEvent>(x => x.Id);
        }
    }
}