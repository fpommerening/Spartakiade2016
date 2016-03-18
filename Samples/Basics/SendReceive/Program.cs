using System;
using EasyNetQ;

namespace FP.Spartakiade2016.Basics.SendReceive
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IBus myBus = null;
            try
            {
                myBus = RabbitHutch.CreateBus("host=MyRabbitMQ");

                

                Console.Write("Please enter content for A:");
                var msgA = Console.ReadLine();
                Console.Write("Please enter  content for B:");
                var msgB = Console.ReadLine();

                

                Console.ReadLine();
            }
            catch (Exception ex)
            {
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
