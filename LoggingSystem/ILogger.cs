/******************************************************************************
 * Filename    = ILogger.cs
 *
 * Author      = LaasyaPriya.Ch
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = LoggingSystem
 *
 * Description = Interface for loggers to demonstrate the Dependency Inversion Principle.
 *****************************************************************************/

namespace LoggingSystem
{
    /// <summary>
    /// An interface that abstracts all loggers.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Log(string message);
    }
}
