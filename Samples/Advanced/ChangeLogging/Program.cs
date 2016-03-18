using System;
using System.IO;
using EasyNetQ;

namespace FP.Spartakiade2016.Advanced.ChangeLogging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.xml"));

            IBus myBus = null;
            try
            {
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
