using Nancy;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["home"];
            };

            Get["/functions/"] = _ =>
            {
                return View["functions"];
            };
        }
    }
}
