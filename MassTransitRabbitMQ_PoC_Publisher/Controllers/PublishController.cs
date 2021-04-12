using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransitRabbitMQ.Transactions.Contracts;
using MassTransitRabbitMQ_PoC_Publisher.Services;
using Microsoft.AspNetCore.Mvc;

namespace MassTransitRabbitMQ_PoC_Publisher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublishController : ControllerBase
    {
        private readonly IEventService _eventService;

        public PublishController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<ActionResult> Post(string value)
        {
            var sampleEvent = new SampleEvent
            {
                Id = Guid.NewGuid(),
                Description = value,
                CreationDate = DateTime.Now
            };
            await _eventService.Publish(sampleEvent, CancellationToken.None);

            return Ok();
        }
    }
}