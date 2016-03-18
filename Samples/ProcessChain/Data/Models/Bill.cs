using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Models
{
    public class Bill
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public DateTime DocumentDate { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Guid Customerid { get; set; }

        public IList<Position> Positions { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public Guid AddessId { get; set; }
    }
}
