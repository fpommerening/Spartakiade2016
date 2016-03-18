using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Customer
{
    public class CustomerMessage : Message
    {
        public override string Type
        {
            get {return "Customer";}
        }
    }
}
