using NLog;

namespace LogRunner
{
    // NLogConcurrencyTest launches five of these as separate processes. The resulting log file should contain exactly 5000 lines.

    public class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                logger.Info("Test it.");
            }
        }
    }
}
