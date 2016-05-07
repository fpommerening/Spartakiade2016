using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Contracts;
using FP.Spartakiade2016.ProcessChain.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FP.Spartakiade2016.ProcessChain.Processes.Messages
{
    public class MessageDispatcher : BusinessProcessBase
    {
        private MarktpartnerRepository _marktpartnerRepository;

        public MessageDispatcher(MarktpartnerRepository marktpartnerRepository)
        {
            _marktpartnerRepository = marktpartnerRepository;
        }

        protected override IDisposable CreateSubscription(IBus bus)
        {
            return bus.SubscribeAsync<ProcessRequest>("MessageDispatcher", OnMessageRequest, c => c.WithTopic("MessageDispatcher"));
        }

        public async Task OnMessageRequest(ProcessRequest processRequest)
        {
            var msgType = typeof(Message).Assembly.GetType(processRequest.MessageType);
            var msg = Convert.ChangeType(processRequest.Message, msgType);
            var message = msg as Message;

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver { };

            string msgAsJson = JsonConvert.SerializeObject(msg, Formatting.Indented, settings);

            var mpSender = _marktpartnerRepository.GetMarktpartnerById(processRequest.SenderId);
            var mpSystem = _marktpartnerRepository.GetSystemMarktpartner();

            using (var handler = new HttpClientHandler {Credentials = new NetworkCredential(mpSystem.UserName, mpSystem.Password)})
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    var result = await client.PostAsync(mpSender.ServiceUrl, new StringContent(msgAsJson)).ConfigureAwait(false);
                    Console.WriteLine(string.Format("Message {0} to {1}: {2}", message.Id, mpSender.ServiceUrl, result));
                }
            }
        }
    }
}
