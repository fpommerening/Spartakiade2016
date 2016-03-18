using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Common
{
    public class Denial : Message
    {
        public string Type { get { return "Denial"; } }

        [Required]
        public Guid SourceMessageId { get; set; }

        [Required]
        public string Reason { get; set; }

        public static Denial Create(string reason, Guid sourceMessageId)
        {
            return new Denial
            {
                Id = Guid.NewGuid(),
                Reason = reason,
                SourceMessageId = sourceMessageId,
                Timestamp = DateTime.UtcNow
            };
        }
    }
}
