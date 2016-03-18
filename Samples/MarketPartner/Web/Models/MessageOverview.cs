using System;
using System.Collections.Generic;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Models
{
    public class MessageOverview
    {
        public DateTime LastUpdate { get; set; }

        public List<Message> Messages { get; set; }
    }
}
