using System;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Models
{
    public class Registration : Request
    {
        
        public string Name { get; set; }

        
        public string FirstName { get; set; }

        public string Title { get; set; }

        
        public DateTime Birthday { get; set; }

        
        public string Email { get; set; }

        public string DeliveryAddressStreet { get; set; }


        public string DeliveryAddressNumber { get; set; }


        public string DeliveryAddressCity { get; set; }


        public string DeliveryAddressZipCode { get; set; }

        public string DeliveryAddressCountry { get; set; }


        public string BillingAddressStreet { get; set; }


        public string BillingAddressNumber { get; set; }


        public string BillingAddressCity { get; set; }


        public string BillingAddressZipCode { get; set; }

        public string BillingAddressCountry { get; set; }
    }
}
