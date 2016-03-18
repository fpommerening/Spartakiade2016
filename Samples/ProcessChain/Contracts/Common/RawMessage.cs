using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Common
{
    public class RawMessage : Message
    {
        public override string Type { get { return "String"; } }

        public string Value { get; set; }
    }
}
