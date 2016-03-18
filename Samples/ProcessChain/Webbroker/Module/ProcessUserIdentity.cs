using System;
using System.Collections.Generic;
using Nancy.Security;

namespace FP.Spartakiade2016.ProcessChain.Webbroker.Module
{
    public class ProcessUserIdentity : IUserIdentity
    {
        public ProcessUserIdentity(string username, Guid id)
        {
            UserName = username;
            Id = id;
            Claims = new List<string>();
        }

        public string UserName { get; private set; }

        public Guid Id { get; private set; }

        public IEnumerable<string> Claims { get; private set; }
    }
}
