using System;

namespace FP.Spartakiade2016.ProcessChain.Contracts
{
    public class AuthorizationResponse
    {
        public bool IsValid { get; set; }

        public Guid Id { get; set; }
    }
}
