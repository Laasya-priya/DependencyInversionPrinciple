/******************************************************************************
 * Filename    = Loggers.cs
 *
 * Author      = LaasyaPriya.Ch
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = LoggingSystem
 *
 * Description = Contains logger implementations for console and file logging.
 *****************************************************************************/


namespace LoggingSystem
{
    /// <summary>
    /// Implementation of the logger that logs to the console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void Log(string message)
        {
            Console.WriteLine($"Inside Console Logger: {message}");
        }
    }

    /// <summary>
    /// Implementation of the logger that logs to a file.
    /// </summary>
    public class FileLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the file.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void Log(string message)
        {
            Console.WriteLine($"Inside File Logger: {message}");
        }
    }
}
