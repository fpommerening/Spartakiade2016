using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;
using FP.Spartakiade2016.ProcessChain.Contracts.Common;

namespace FP.Spartakiade2016.ProcessChain.Processes.Invoic
{
    public class Bill : BusinessProcessBase
    {
        protected override IDisposable CreateSubscription(IBus bus)
        {
            return bus.SubscribeAsync<ProcessRequest>("Bill", OnMessage, c => c.WithTopic("Bill"));
        }

        private async Task OnMessage(ProcessRequest processRequest)
        {
            var confirm = Confirmation.Create(processRequest.MessageId);
            await StartProcess("MessageDispatcher", confirm, processRequest.SenderId).ConfigureAwait(false);
        }
    }
}
