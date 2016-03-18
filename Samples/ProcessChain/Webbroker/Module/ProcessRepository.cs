using System;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;

namespace FP.Spartakiade2016.ProcessChain.Webbroker.Module
{
    public class ProcessRepository
    {
        public AuthorizationResponse Authorize(string userName, string password)
        {
           throw new NotImplementedException();
        }

        public Task StartProcess(string processName, Message message, Guid senderId)
        {
            throw new NotImplementedException();
        }

    }
}
