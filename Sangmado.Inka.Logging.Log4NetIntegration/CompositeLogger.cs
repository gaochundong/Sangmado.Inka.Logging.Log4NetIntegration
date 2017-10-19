namespace Sangmado.Inka.Logging.Log4NetIntegration
{
    public class CompositeLogger : Sangmado.Inka.Logging.ILogger
    {
        public CompositeLogger()
        {
        }

        public Sangmado.Inka.Logging.ILog Get(string name)
        {
            return new CompositeLog(Logrila.Logging.Logger.Get(name));
        }

        public static void Use()
        {
            Logrila.Logging.Logger.UseLogger(new Logrila.Logging.Log4NetIntegration.Log4NetLogger());
            Sangmado.Inka.Logging.Logger.UseLogger(new CompositeLogger());
        }
    }
}
