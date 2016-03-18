using System;

namespace FP.Spartakiade2016.Logging.ConsoleListener
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
            
                Console.WriteLine("Logger gestartet...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Verbindung ist fehlgeschlagen");
                Console.WriteLine(ex);
            }
            finally
            {
            
            }

            Console.WriteLine("Logger beendet...");
        }
    }
}
