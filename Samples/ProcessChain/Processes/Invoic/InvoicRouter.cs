using System;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;

namespace FP.Spartakiade2016.ProcessChain.Processes.Invoic
{
    public class InvoicRouter : BusinessProcessBase
    {
        protected override IDisposable CreateSubscription(IBus bus)
        {
            return bus.SubscribeAsync<ProcessRequest>("InvoicRouter", OnMessage, c => c.WithTopic("InvoicRouter"));
        }

        private async Task OnMessage(ProcessRequest processRequest)
        {
            if (processRequest.MessageType == typeof(Contracts.Invoic.Bill).FullName)
            {
                await StartProcess("Bill", processRequest.Message, processRequest.SenderId).ConfigureAwait(false);
            }
            else if (processRequest.MessageType == typeof(Contracts.Invoic.Reversal).FullName)
            {
                await StartProcess("Reversal", processRequest.Message, processRequest.SenderId).ConfigureAwait(false);
            }
            else
            {
                throw new NotSupportedException(string.Format("Message type {0} is not supported", processRequest.MessageType));
            }
        }
    }
}

