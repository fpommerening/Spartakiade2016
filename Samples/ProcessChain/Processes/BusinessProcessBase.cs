using System;
using EasyNetQ;

namespace FP.Spartakiade2016.ProcessChain.Processes
{
    public abstract class BusinessProcessBase : IBusinessProcess
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ConnectToBus(IBus bus)
        {
            throw new NotImplementedException();
        }

        protected abstract IDisposable CreateSubscription(IBus bus);
    }
}
