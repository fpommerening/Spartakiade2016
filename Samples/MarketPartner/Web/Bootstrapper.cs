using FP.Spartakiade2016.ProcessChain.MarketPartner.Modules;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<MessageRepository>().AsSingleton();
            base.ApplicationStartup(container, pipelines);
        }
    }
}
