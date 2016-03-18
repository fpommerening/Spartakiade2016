using System;

namespace FP.Spartakiade2016.Logging.Contacts
{
    public class LogItem
    {
        public DateTime Timestamp { get; set; }

        public String RemoteHost { get; set; }

        public Guid SessionId { get; set; }

        public string InstanceHost { get; set; }

        public RequestState State { get; set; }
    }
}
