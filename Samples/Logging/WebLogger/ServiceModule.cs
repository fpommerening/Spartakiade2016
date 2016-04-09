using System;
using FP.Spartakiade2016.Logging.Contacts;
using Nancy;

namespace FP.Spartakiade2016.Weblogger
{
    public class ServiceModule : NancyModule
    {
        public ServiceModule(LoggingRepository loggingRepository)
        {
            Get["/Service/{sessionId}", true] = async (parameter, ct)
                =>
            {
                Guid sessionId;
                var timestamp = DateTime.UtcNow;
                var remoteHost = Context.Request.UserHostAddress;

                if (!Guid.TryParse(parameter.sessionId, out sessionId))
                {
                    await loggingRepository.SendErrorLog(remoteHost, timestamp,
                        Environment.MachineName);
                    return HttpStatusCode.BadRequest;
                }

                await loggingRepository.SendLog(sessionId, remoteHost, timestamp,
                    Environment.MachineName);

                return Response.AsJson(new {Session = sessionId, Timestamp = timestamp, Hostname = Environment.MachineName});
            };

        }
    }
}
