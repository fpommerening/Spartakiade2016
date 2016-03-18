using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Models
{
    public class Position
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Bill Bill { get; set; }

        [Required]
        public Guid BillId { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public decimal NetAmount { get; set; }

        public decimal GrossAmmount { get; set; }

        public decimal TaxAmmount { get; set; }

        [Required]
        public string Article { get; set; }

        public string Comment { get; set; }

        [Required]
        public DateTime ValidFrom { get; set; }
        [Required]
        public DateTime ValidTo { get; set; }
    }
}
