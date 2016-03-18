using System;
using EasyNetQ;

namespace FP.Spartakiade2016.ProcessChain.Processes
{
    public interface IBusinessProcess : IDisposable
    {
        void ConnectToBus(IBus bus);
    }
}
