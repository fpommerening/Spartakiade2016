using System;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;

namespace FP.Spartakiade2016.ProcessChain.Processes
{
    public abstract class BusinessProcessBase : IBusinessProcess
    {
        private IDisposable _subscription;
        protected IBus Bus { get; private set; }

        public void ConnectToBus(IBus bus)
        {
            Bus = bus;
            _subscription = CreateSubscription(bus);
        }

        protected abstract IDisposable CreateSubscription(IBus bus);
        

        public void Dispose()
        {
            if (_subscription != null)
            {
                _subscription.Dispose();
                _subscription = null;
            }
        }

        public Task StartProcess(string processName, Message message, Guid senderId)
        {
            var processRequest = ProcessRequest.Create(message, senderId);
            return Bus.PublishAsync(processRequest, processName);
        }

    }
}
