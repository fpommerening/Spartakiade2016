using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Invoic
{
    public class InvoicMessage : Message
    {
        public override string Type
        {
            get { return "Invoic"; }
        }
    }
}
