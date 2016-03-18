using System;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Models
{
    public class Bill : Request
    {
        public string Number { get; set; }

        public DateTime DocumentDate { get; set; }

        public string CustomerNumber { get; set; }


        public string AddressStreet { get; set; }


        public string AddressNumber { get; set; }


        public string AddressCity { get; set; }


        public string AddressZipCode { get; set; }

        public string AddressCountry { get; set; }


        public int PosNumber { get; set; }

        public decimal PosNetAmount { get; set; }

        public decimal PosGrossAmmount { get; set; }

        public decimal PosTaxAmmount { get; set; }

        
        public string PosArticle { get; set; }

        public string PosComment { get; set; }

        public DateTime PosValidFrom { get; set; }

        public DateTime PosValidTo { get; set; }


    }
}
