using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using FP.Spartakiade2016.ProcessChain.MarketPartner.Models;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner.Modules
{
    public class MessageRepository
    {
        private readonly ConcurrentQueue<IncomingMessage> messages = new ConcurrentQueue<IncomingMessage>();

        public List<Message> GetMessages()
        {
            return messages.Select(x => new Message {Content = x.Content, Timestamp = x.Timestamp}).OrderByDescending(x=>x.Timestamp).ToList();
        }

        public void AddMessage(string content)
        {
            while (messages.Count > 25)
            {
                IncomingMessage messageToRemove;
                messages.TryDequeue(out messageToRemove);
            }
            messages.Enqueue(new IncomingMessage
            {
                Content = content,
                Timestamp = DateTime.Now
            });
        }

    }

    
}
