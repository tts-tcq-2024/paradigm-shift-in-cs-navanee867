using System;
namespace paradigm_shift_csharp
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }
    }
}
