using System.IO;
using Nancy;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class ServiceModule : NancyModule
    {
        public ServiceModule(MessageRepository repo)
        {
            Post["/service/", true] = async (parameter, ct)
                =>
            {
                Context.Request.Body.Position = 0;
                string message;
                using (var sr = new StreamReader(Context.Request.Body))
                {
                    message = await sr.ReadToEndAsync().ConfigureAwait(false);
                }
                repo.AddMessage(message);
                return HttpStatusCode.OK;
            };
        }


    }
}
