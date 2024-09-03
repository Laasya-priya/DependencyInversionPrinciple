/******************************************************************************
 * Filename    = LoggingSystemUnitTests.cs
 *
 * Author      = LaasyaPriya.Ch
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = UnitTestLoggingSystem
 *
 * Description = Unit tests for the logging system demonstrating DIP.
 *****************************************************************************/

using LoggingSystem;

namespace UnitTests
{
    /// <summary>
    /// Mock logger that records log messages for testing purposes.
    /// </summary>
    class MockLogger : ILogger
    {
        public MockLogger()
        {
            Messages = new List<string>();
        }

        public List<string> Messages { get; private set; }

        /// <summary>
        /// Logs a message by adding it to the list of messages.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void Log(string message)
        {
            Messages.Add(message);
        }
    }

    /// <summary>
    /// Unit tests for the logging system.
    /// </summary>
    [TestClass]
    public class LoggingSystemUnitTests
    {
        /// <summary>
        /// Tests that the logger has no messages if the application is not run.
        /// </summary>
        [TestMethod]
        public void TestNoLoggingWithoutRun()
        {
            // Arrange
            MockLogger MockLogger = new ();

            Assert.AreEqual(0, MockLogger.Messages.Count);
        }

        /// <summary>
        /// Tests logging using the ConsoleLogger implementation.
        /// </summary>
        [TestMethod]
        public void TestConsoleLoggerLogging()
        {
            ConsoleLogger ConLogger = new ();
            ApplicationLogger App = new (ConLogger);

            using var sw = new StringWriter();
            
                Console.SetOut(sw);

                // Act
                App.Run();

                // Assert
                string expectedOutput = "Inside Console Logger: Application has started." + Environment.NewLine +
                                        "Inside Console Logger: Application has finished." + Environment.NewLine;
                Assert.AreEqual(expectedOutput, sw.ToString());
            
        }


        /// <summary>
        /// Tests logging using the FileLogger implementation.
        /// </summary>
        [TestMethod]
        public void TestFileLoggerLogging()
        {
            FileLogger FilLogger = new ();
            ApplicationLogger App = new (FilLogger);


            using var sw = new StringWriter();
            
                Console.SetOut(sw);

                // Act
                App.Run();

                // Assert
                string expectedOutput = "Inside File Logger: Application has started." + Environment.NewLine +
                                        "Inside File Logger: Application has finished." + Environment.NewLine;
                Assert.AreEqual(expectedOutput, sw.ToString());
        }
    }
}
