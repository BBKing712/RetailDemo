using Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class DoDummyStuffHandler : IHandleMessages<DoDummyStuff>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        static Random random = new Random();

        public Task Handle(DoDummyStuff message, IMessageHandlerContext context)
        {
            log.Info($"Received DoDummyStuff, Id = {message.Id}");

            // This is normally where some business logic would occur


            var dummyStuffDone = new DummyStuffDone
            {
                DummyStuffId = message.Id
            };

            log.Info($"Publishing DummyStuffDone, Id = {message.Id}");

            return context.Publish(dummyStuffDone);
        }
    }
}
