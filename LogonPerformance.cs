using System;
using System.Diagnostics;

namespace Telemetry
{
    public class LogonPerformance
    {
        private static Stopwatch stopWatch;
        private static string elapsedTime;
        public static void Start()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();

        }
        public static string StopAndGetResult()
        {
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime);
            return "LogonPerformance: "+ elapsedTime;
        }
    }
}
