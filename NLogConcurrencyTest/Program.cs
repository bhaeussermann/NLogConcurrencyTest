using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace NLogConcurrencyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("log.txt"))
                File.Delete("log.txt");

            var start = DateTime.Now;

            List<Process> processes = new List<Process>();
            for (int i = 0; i < 5; i++)
            {
                var process = Process.Start(new ProcessStartInfo(typeof(LogRunner.Program).Assembly.Location));
                processes.Add(process);
            }

            foreach (var nextProcess in processes)
                nextProcess.WaitForExit();

            Console.WriteLine("Duration: " + (DateTime.Now - start));
            Console.ReadLine();

            // There should be exactly 5000 lines in the file.
        }
    }
}
