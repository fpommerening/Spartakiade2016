using System;

namespace FP.Spartakiade2016.ProcessChain.Data.Objects
{
    public class BOAddress
    {
        public Guid Id { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
    }
}
