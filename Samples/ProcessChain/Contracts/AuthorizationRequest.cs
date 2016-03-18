using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.Spartakiade2016.ProcessChain.Contracts
{
    public class AuthorizationRequest
    {
        public string UserName { get; set; }

        public string Passwort { get; set; }
    }
}
