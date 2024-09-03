/******************************************************************************
 * Filename    = Application.cs
 *
 * Author      = LaasyaPriya.Ch
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = LoggingSystem
 *
 * Description = Application demonstrating Dependency Inversion Principle.
 *****************************************************************************/


namespace LoggingSystem
{
    /// <summary>
    /// A high-level class that depends on the abstraction for logging.
    /// </summary>
    public class ApplicationLogger
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLogger"/> class.
        /// </summary>
        /// <param name="Logger">The logger instance.</param>
        public ApplicationLogger(ILogger Logger)
        {
            _logger = Logger;
        }

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void Run()
        {
            _logger.Log("Application has started.");
            _logger.Log("Application has finished.");
        }
    }

    /// <summary>
    /// The main program class demonstrating the Dependency Inversion Principle.
    /// </summary>
    public class LoggingSystemDIP
    {
        public static void Main(string[] args)
        {
            // Creating an instance of a logger (console logger).
            ILogger ConLogger = new ConsoleLogger();

            // High-level application service using the console logger.
            ApplicationLogger AppConLogger = new (ConLogger);
            AppConLogger.Run();

            // Creating an instance of a logger (file logger).
            ILogger FilLogger = new FileLogger();

            // High-level application service using the file logger.
            ApplicationLogger AppFilLogger = new (FilLogger);
            AppFilLogger.Run();
        }
    }
}
