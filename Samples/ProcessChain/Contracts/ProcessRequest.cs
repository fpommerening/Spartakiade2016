using System;
using System.Collections.Generic;

namespace FP.Spartakiade2016.ProcessChain.Contracts
{
    public class ProcessRequest
    {
        public Guid MessageId { get; set; }

        public string MessageType { get; set; }

        public Message Message { get; set; }

        public List<ProcessParameter> Parameters { get; set; }

        public Guid SenderId { get; set; }

        public static ProcessRequest Create(Message msg, Guid senderId)
        {
            return new ProcessRequest
            {
                Message = msg,
                MessageType = msg.GetType().FullName,
                MessageId = msg.Id,
                SenderId = senderId
            };
        }
    }
}
