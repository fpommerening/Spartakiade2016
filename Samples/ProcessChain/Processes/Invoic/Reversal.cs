using FP.Spartakiade2016.ProcessChain.Data;

namespace FP.Spartakiade2016.ProcessChain.Processes.Invoic
{
    public class Reversal
    {
        private CustomerRepository _customerRepository;

        public Reversal(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
