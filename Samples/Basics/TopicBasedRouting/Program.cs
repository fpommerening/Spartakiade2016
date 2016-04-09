using System;
using EasyNetQ;

namespace FP.Spartakiade2016.TopicBasedRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBus myBus = null;
            try
            {
                myBus = RabbitHutch.CreateBus("host=MyRabbitMQ");
                myBus.Subscribe<MyMessage>("BlueLine", msg =>
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Say hallo to {0}", msg.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                },
                x=>x.WithTopic("BLUE"));

                myBus.Subscribe<MyMessage>("RedLine", msg =>
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Say hallo to {0}", msg.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                },
                x => x.WithTopic("RED"));
                string input = string.Empty;

                do
                {
                    Console.WriteLine("select a color (valid are 'red' or 'blue')");
                    var color = Console.ReadLine();
                    Console.WriteLine("Enter a name or nothing to leave");
                    input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input))
                    {
                        myBus.Publish(new MyMessage {Name = input}, color.ToUpper());
                    }
                    System.Threading.Thread.Sleep(2000);
                } while (!string.IsNullOrEmpty(input));
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
