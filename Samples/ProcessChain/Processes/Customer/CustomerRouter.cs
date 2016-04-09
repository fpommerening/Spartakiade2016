using System;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;

namespace FP.Spartakiade2016.ProcessChain.Processes.Customer
{
    public class CustomerRouter : BusinessProcessBase
    {
        protected override IDisposable CreateSubscription(IBus bus)
        {
            return bus.SubscribeAsync<ProcessRequest>("CustomerRouter", OnMessage, c => c.WithTopic("CustomerRouter"));
        }

        private async Task OnMessage(ProcessRequest processRequest)
        {
            if (processRequest.MessageType == typeof(Contracts.Customer.Registration).FullName)
            {
                await StartProcess("Registration", processRequest.Message, processRequest.SenderId).ConfigureAwait(false);
            }
            else
            {
                throw new NotSupportedException(string.Format("Message type {0} is not supported", processRequest.MessageType));
            }
        }
    }
}
