using System;

namespace Sangmado.Inka.Logging.Log4NetIntegration
{
    public class CompositeLog : Sangmado.Inka.Logging.ILog
    {
        private readonly Logrila.Logging.ILog _log;

        public CompositeLog(Logrila.Logging.ILog log)
        {
            if (log == null)
                throw new ArgumentNullException("log");
            _log = log;
        }

        public bool IsTraceEnabled
        {
            get { return _log.IsTraceEnabled; }
        }

        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }

        public void Trace(object obj)
        {
            _log.Trace(obj);
        }

        public void Trace(object obj, Exception exception)
        {
            _log.Trace(obj, exception);
        }

        public void Trace(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Trace(ConvertProvider(messageProvider));
        }

        public void Debug(object obj)
        {
            _log.Debug(obj);
        }

        public void Debug(object obj, Exception exception)
        {
            _log.Debug(obj, exception);
        }

        public void Debug(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Debug(ConvertProvider(messageProvider));
        }

        public void Info(object obj)
        {
            _log.Info(obj);
        }

        public void Info(object obj, Exception exception)
        {
            _log.Info(obj, exception);
        }

        public void Info(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Info(ConvertProvider(messageProvider));
        }

        public void Warn(object obj)
        {
            _log.Warn(obj);
        }

        public void Warn(object obj, Exception exception)
        {
            _log.Warn(obj, exception);
        }

        public void Warn(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Warn(ConvertProvider(messageProvider));
        }

        public void Error(object obj)
        {
            _log.Error(obj);
        }

        public void Error(object obj, Exception exception)
        {
            _log.Error(obj, exception);
        }

        public void Error(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Error(ConvertProvider(messageProvider));
        }

        public void Fatal(object obj)
        {
            _log.Fatal(obj);
        }

        public void Fatal(object obj, Exception exception)
        {
            _log.Fatal(obj, exception);
        }

        public void Fatal(Sangmado.Inka.Logging.LogOutputProvider messageProvider)
        {
            _log.Fatal(ConvertProvider(messageProvider));
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.TraceFormat(formatProvider, format, args);
        }

        public void TraceFormat(string format, params object[] args)
        {
            _log.TraceFormat(format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.DebugFormat(formatProvider, format, args);
        }

        public void DebugFormat(string format, params object[] args)
        {
            _log.DebugFormat(format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.InfoFormat(formatProvider, format, args);
        }

        public void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.WarnFormat(formatProvider, format, args);
        }

        public void WarnFormat(string format, params object[] args)
        {
            _log.WarnFormat(format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.ErrorFormat(formatProvider, format, args);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _log.ErrorFormat(format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _log.FatalFormat(formatProvider, format, args);
        }

        public void FatalFormat(string format, params object[] args)
        {
            _log.FatalFormat(format, args);
        }

        private Logrila.Logging.LogLevel ConvertLogLevel(Sangmado.Inka.Logging.LogLevel level)
        {
            if (level == Sangmado.Inka.Logging.LogLevel.Fatal)
                return Logrila.Logging.LogLevel.Fatal;
            else if (level == Sangmado.Inka.Logging.LogLevel.Error)
                return Logrila.Logging.LogLevel.Error;
            else if (level == Sangmado.Inka.Logging.LogLevel.Warn)
                return Logrila.Logging.LogLevel.Warn;
            else if (level == Sangmado.Inka.Logging.LogLevel.Info)
                return Logrila.Logging.LogLevel.Info;
            else if (level == Sangmado.Inka.Logging.LogLevel.Debug)
                return Logrila.Logging.LogLevel.Debug;
            else if (level == Sangmado.Inka.Logging.LogLevel.Trace)
                return Logrila.Logging.LogLevel.Trace;

            return Logrila.Logging.LogLevel.None;
        }

        private Logrila.Logging.LogOutputProvider ConvertProvider(Sangmado.Inka.Logging.LogOutputProvider provider)
        {
            return () =>
            {
                object obj = provider();
                return obj == null ? "" : obj.ToString();
            };
        }
    }
}
