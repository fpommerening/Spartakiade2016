using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;
using FP.Spartakiade2016.ProcessChain.Contracts.Common;
using FP.Spartakiade2016.ProcessChain.Data;
using FP.Spartakiade2016.ProcessChain.Data.Objects;
using Newtonsoft.Json;

namespace FP.Spartakiade2016.ProcessChain.Processes.Customer
{
    public class Registration : BusinessProcessBase
    {
        private CustomerRepository _customerRepository;

        public Registration(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        protected override IDisposable CreateSubscription(IBus bus)
        {
            return bus.SubscribeAsync<ProcessRequest>("Registration", OnMessageRequest, c => c.WithTopic("Registration"));
        }

        public async Task OnMessageRequest(ProcessRequest processRequest)
        {
            var msg = (Contracts.Customer.Registration) processRequest.Message;

            Message result = null;

            var mappedRegistation = new BOCustomer();

            var denial = Denial.Create("Kunde kenn ich schon :-(", processRequest.MessageId);
            await StartProcess("MessageDispatcher", denial, processRequest.SenderId).ConfigureAwait(false);

            //if (await _customerRepository.CustomerExists(mappedRegistation))
            //{
            //    result = Denial.Create("Der Kunden ist bereits vorhanden", msg.Id);
            //}
            //else
            //{
            //    result = Confirmation.Create(msg.Id);
            //}
            //await StartProcess("MessageDispatcher", result, processRequest.SenderId);
        }
    }
}
