using System;
using System.ComponentModel.DataAnnotations;


namespace FP.Spartakiade2016.ProcessChain.Contracts
{
    public class Message
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public virtual string Type { get; set; }
    }
}
