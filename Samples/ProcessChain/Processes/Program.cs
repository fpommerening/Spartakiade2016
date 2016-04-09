using System;
using System.Linq;
using System.Threading;
using EasyNetQ;
using FP.Spartakiade2016.ProcessChain.Processes.Messages;
using FP.Spartakiade2016.ProcessChain.Data;
using FP.Spartakiade2016.ProcessChain.Processes.Customer;
using FP.Spartakiade2016.ProcessChain.Processes.Invoic;


namespace FP.Spartakiade2016.ProcessChain.Processes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBus myBus = null;
            IBusinessProcess process = null;
            Console.WriteLine("Starting Processhost {0}", String.Join(" / ", args));
            try
            {
                myBus = RabbitHutch.CreateBus("host=MyRabbitMQ");

                if(args.Any() && !string.IsNullOrEmpty(args[0]))
                {
                    process = FindProcess(args[0]);
                }

                if (process != null)
                {
                    process.ConnectToBus(myBus);
                    while (Console.ReadLine() != "quit") { Thread.Sleep(Int32.MaxValue); }
                }
                else
                {
                    Console.WriteLine("Prozess ist leer");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                process?.Dispose();
                myBus?.Dispose();
            }
            
        }

        private static IBusinessProcess FindProcess(string processName)
        {
            switch (processName.ToLowerInvariant())
            {
                case "authorization":
                    return new Authorization(new MarktpartnerRepository());
                case "messagerouter":
                    return new MessageRouter();
                case "messagedispatcher":
                    return new MessageDispatcher(new MarktpartnerRepository());
                case "invoicrouter":
                    return new InvoicRouter();
                case "bill":
                    return new Bill();
                case "reversal":
                    return new Reversal();
                case "customerrouter":
                    return new CustomerRouter();
                case "registration":
                    return new Registration(new CustomerRepository());
                default:
                    return null;

            }
        }
    }
}
