using System;
using System.IO;
using System.Text;

namespace loger
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            if (!File.Exists("D:\\logger.txt"))
            {
                File.Create("D:\\logger.txt");
            }

            try
            {
                StreamWriter sw = new StreamWriter("D:\\logger.txt", true, Encoding.ASCII);
                sw.Write("\n");
                sw.Write(message);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
    public class LoggerFactory
    {
        public static ILogger CreateFileLogger()
        {
            var logger = new FileLogger();
            return logger;
        }

        public static ILogger CreateConsoleLogger()
        {
            var logger = new ConsoleLogger();
            return logger;
        }
    }
}


