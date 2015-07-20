using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogConcurrencyTest
{
	class Program
	{
		static void Main(string[] args)
		{
			if (File.Exists("log.txt"))
				File.Delete("log.txt");

			List<Process> processes = new List<Process>();
			for (int i = 0; i < 3; i++)
			{
				var process = Process.Start(new ProcessStartInfo(typeof(LogRunner.Program).Assembly.Location));
				processes.Add(process);
			}

			foreach (var nextProcess in processes)
				nextProcess.WaitForExit();

			// There should be exactly 300 lines in the file.
		}
	}
}
