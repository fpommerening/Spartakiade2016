using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Objects
{
    public class BOPosition
    {
        public Guid Id { get; set; }

        public BOBill Bill { get; set; }

        public int Number { get; set; }

        public decimal NetAmount { get; set; }

        public decimal GrossAmmount { get; set; }

        public decimal TaxAmmount { get; set; }

        public string Article { get; set; }

        public string Comment { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }
    }
}
