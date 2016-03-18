using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Models
{
    public class Reversal
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public DateTime DocumentDate { get; set; }

        [Required]
        public Bill ReferenceBill { get; set; }

        [Required]
        public Guid ReferenceBillId { get; set; }

    }
}
