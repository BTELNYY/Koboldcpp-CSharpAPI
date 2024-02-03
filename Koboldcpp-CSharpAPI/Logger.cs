using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koboldcpp_CSharpAPI
{
    public static class Logger
    {
        public static event Action<LogData>? OnLog;

        public static void Log(LogLevel level, string message)
        {
            LogData data = new LogData();
            data.LogLevel = level;
            data.Message = message;
            data.Time = DateTime.Now;
            OnLog?.Invoke(data);
        }

        public static void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }

        public static void LogWarning(string message)
        {
            Log(LogLevel.Warning, message);
        }

        public static void LogInfo(string message)
        {
            Log(LogLevel.Info, message);
        }

        public static void LogVerbose(string message)
        {
            Log(LogLevel.Verbone, message);
        }

        public static void LogDebug(string message) 
        {
            Log(LogLevel.Debug, message);
        }
    }

    public struct LogData
    {
        public string Message { get; set; }

        public DateTime Time { get; set; }

        public LogLevel LogLevel { get; set; }
    }

    public enum LogLevel
    {
        Error,
        Warning,
        Info,
        Verbone,
        Debug,
    }
}
