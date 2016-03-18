using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using FP.Spartakiade2016.ProcessChain.Contracts.Common;
using FP.Spartakiade2016.ProcessChain.Contracts.Customer;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Invoic
{
    public class Bill : InvoicMessage
    {
        [Required]
        public string Number { get; set; }

        [Required]
        public DateTime DocumentDate { get; set; }

        [Required]
        public string CustomerNumber { get; set; }

        public Collection<Position> Positions { get; set; }

        public Address Address { get; set; }
    }
}
