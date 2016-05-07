using FP.Spartakiade2016.ProcessChain.Contracts;
using FP.Spartakiade2016.ProcessChain.Contracts.Invoic;
using FP.Spartakiade2016.ProcessChain.Data;
using FP.Spartakiade2016.ProcessChain.Processes.Customer;
using FP.Spartakiade2016.ProcessChain.Processes.Messages;

namespace FP.Spartakiade2016.ProcessChain.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Contracts.Customer.Registration msg = new Contracts.Customer.Registration();
            var repo = new CustomerRepository();
            Processes.Customer.Registration processes = new Processes.Customer.Registration(repo);
            var req = new ProcessRequest {Message = msg};
            
        }
    }
}
