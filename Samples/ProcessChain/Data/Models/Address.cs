using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Models
{
    public class Address
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public string Country { get; set; }
    }
}
