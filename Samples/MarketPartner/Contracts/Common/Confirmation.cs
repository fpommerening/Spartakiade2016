using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Common
{
    public class Confirmation : Message
    {
        public override string Type { get { return "Confirmation"; } }

        [Required]
        public Guid SourceMessageId { get; set; }

        public static Confirmation Create(Guid sourceMessageId)
        {
            return new Confirmation
            {
                Id = Guid.NewGuid(),
                SourceMessageId = sourceMessageId,
                Timestamp = DateTime.UtcNow
            };
        }
    }
}
