using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.Logging.Contacts;

namespace FP.Spartakiade2016.Weblogger
{
    public class LoggingRepository
    {
        public Task SendErrorLog(string remoteHost, DateTime timestamp, string instanceHost)
        {
            var logItem = new LogItem
            {
                Timestamp = timestamp,
                RemoteHost = remoteHost,
                InstanceHost = instanceHost,
                State = RequestState.Error
            };

            return GetOrCreateBus().PublishAsync(logItem);
        }

        public Task SendLog(Guid sessionId, string remoteHost, DateTime timestamp, string instanceHost)
        {
            var logItem = new LogItem
            {
                Timestamp = timestamp,
                SessionId = sessionId,
                RemoteHost = remoteHost,
                InstanceHost = instanceHost,
                State = RequestState.OK
            };

            return GetOrCreateBus().PublishAsync(logItem);
        }

        private IBus bus = null;
        private IBus GetOrCreateBus()
        {
            return bus ?? (bus = RabbitHutch.CreateBus("host=MyRabbitMQ"));
        }
    }
}
