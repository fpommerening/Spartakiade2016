using FP.Spartakiade2016.ProcessChain.Data;

namespace FP.Spartakiade2016.ProcessChain.Processes.Customer
{
    public class Registration
    {
        private CustomerRepository _customerRepository;

        public Registration(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

       
    }
}
