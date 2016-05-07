using System;
using EasyNetQ;

namespace FP.Spartakiade2016.Basics.Connecting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBus myBus = null;
            try
            {
                myBus = RabbitHutch.CreateBus("host=MyRabbitMQ");
                Console.WriteLine("Verbindung wurde aufgebaut: {0}", myBus.IsConnected);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Verbindung ist fehlgeschlagen");
                Console.WriteLine(ex);
            }
            finally
            {
                myBus?.Dispose();
            }
            Console.ReadLine();
        }
    }
}
