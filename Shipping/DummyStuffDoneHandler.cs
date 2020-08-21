using Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    public class DummyStuffDoneHandler : IHandleMessages<DummyStuffDone>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(DummyStuffDone message, IMessageHandlerContext context)
        {
            log.Info($"Shipping has received DummyStuffDone, DummyStuffId = {message.DummyStuffId}");
            return Task.CompletedTask;
        }
    }
}
