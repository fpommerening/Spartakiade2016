using System;
using System.ComponentModel.DataAnnotations;

namespace FP.Spartakiade2016.ProcessChain.Data.Objects
{
    public class BOCustomer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string Number { get; set; }

        public string Title { get; set; }
        
        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public BOAddress DeliveryAddress { get; set; }

        public BOAddress BillingAddress { get; set; }
    }
}
