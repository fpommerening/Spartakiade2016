using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Contracts.Common
{
    public class Address
    {
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
