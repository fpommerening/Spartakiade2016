using System;
using Nancy;

namespace FP.Spartakiade2016.Weblogger
{
    public class ServiceModule : NancyModule
    {
        public ServiceModule()
        {
            Get["/Service/{sessionId}", true] = async (parameter, ct)
                =>
            {
                Guid sessionId;
                var timestamp = DateTime.UtcNow;
                var remoteHost = Context.Request.UserHostAddress;

                

                if (!Guid.TryParse(parameter.sessionId, out sessionId))
                {
                    return HttpStatusCode.BadRequest;
                }
                
                

                return Response.AsJson(new {Session = sessionId, Timestamp = timestamp, Hostname = Environment.MachineName});
            };

        }
    }
}
