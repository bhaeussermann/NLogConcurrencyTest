using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogRunner
{
	// NLogConcurrencyTest launches three of these as separate processes. The resulting log file should contain exactly 300 lines.

	public class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			for (int i = 0; i < 100; i++)
			{
				logger.Info("Test it.");
				Thread.Sleep(130);
			}
		}
	}
}
