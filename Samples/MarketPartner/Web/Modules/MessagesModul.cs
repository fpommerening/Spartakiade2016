using System;
using FP.Spartakiade2016.ProcessChain.MarketPartner.Models;
using Nancy;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class MessagesModul : NancyModule
    {
        public MessagesModul(MessageRepository repo)
        {
            Get["/messages"] = x =>
            {
                var model = new MessageOverview
                {
                    LastUpdate = DateTime.Now,
                    Messages = repo.GetMessages()
                };
                return View["messages", model];
            };
        }


    }
}
