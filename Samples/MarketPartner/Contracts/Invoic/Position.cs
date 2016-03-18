using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Invoic
{
    public class Position
    {
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
