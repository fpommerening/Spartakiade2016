using Nancy;

namespace FP.Spartakiade2016.Weblogger
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hallo Spartakiade 2016";
        }
    }
}
