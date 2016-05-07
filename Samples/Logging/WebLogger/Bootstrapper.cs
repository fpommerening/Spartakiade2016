using EasyNetQ;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace FP.Spartakiade2016.Weblogger
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            container.Register<LoggingRepository>().AsSingleton();
            base.ApplicationStartup(container, pipelines);
        }
    }
}
