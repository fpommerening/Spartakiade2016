using FP.Spartakiade2016.ProcessChain.Data;

namespace FP.Spartakiade2016.ProcessChain.Processes.Invoic
{
    public class Bill
    {
        private CustomerRepository _customerRepository;

        public Bill(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
