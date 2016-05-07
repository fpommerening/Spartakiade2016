using System;
using System.Text;
using EasyNetQ;
using log4net;

namespace FP.Spartakiade2016.Advanced.ChangeLogging
{
    public class Log4NetLogger : IEasyNetQLogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(RabbitBus));

        public void DebugWrite(string format, params object[] args)
        {
            var message = SafeFormat(format, args);
            log.Debug(message);
        }

        public void InfoWrite(string format, params object[] args)
        {
            var message = SafeFormat(format, args);
            log.Info(message);
        }

        public void ErrorWrite(string format, params object[] args)
        {
            var message = SafeFormat(format, args);
            log.Error(message);
        }

        public void ErrorWrite(Exception exception)
        {
            log.Error(exception);
        }

        private string SafeFormat(string format, object[] args)
        {
            try
            {
                return string.Format(format, args);
            }
            catch (FormatException ex)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(string.Format("Fehler beim Formatieren der Logmeldung: {0}", ex));
                sb.AppendLine("Originale Logmeldung:");
                sb.AppendLine(format);

                if (args != null)
                {
                    sb.AppendLine("Argumente:");
                    for (int i = 0; i < args.Length; i++)
                    {
                        sb.AppendLine(string.Format("Argument {0}: {1}", i, args[i]));
                    }
                }

                return sb.ToString();
            }
        }
    }
}
