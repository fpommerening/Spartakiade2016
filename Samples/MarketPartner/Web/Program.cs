using System;
using System.Threading;
using Nancy.Hosting.Self;

namespace FP.Spartakiade2016.ProcessChain.MarketPartner
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:12088")))
            {
                host.Start();

                while (Console.ReadLine() != "quit") { Thread.Sleep(Int32.MaxValue); }
            }
        }
    }
}
