using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class DoDummyStuff : ICommand
    {
        public string Id { get; set; }
    }
}
