using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace FP.Spartakiade2016.ProcessChain.Webbroker.Module
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Spartakiade 2016 ProcessChain Webbroker";
        }
    }
}
