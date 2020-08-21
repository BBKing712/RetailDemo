using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class DummyStuffDone : IEvent
    {
        public string DummyStuffId { get; set; }

    }
}
