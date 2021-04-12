namespace MassTransitRabbitMQ_PoC_Publisher.Settings
{
    public class QueueSettings
    {
        public string UserNamed { get; set; }
        public string Password { get; set; }
        public string HostName { get; set; }
        public string VirtualHost { get; set; }
        public string QueueName { get; set; }
    }
}