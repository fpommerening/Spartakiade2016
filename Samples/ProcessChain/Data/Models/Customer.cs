using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Models
{
    public class Customer
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Number { get; set; }

        public string Title { get; set; }
        
        public DateTime Birthday { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Address DeliveryAddress { get; set; }

        [Required]
        public Guid DeliveryAddressId { get; set; }

        public Address BillingAddress { get; set; }

        public Guid? BillingAddressId { get; set; }

    }
}
