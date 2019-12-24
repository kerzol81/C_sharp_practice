using System;
using System.Threading;

namespace StopWatch
{
        class Program
    {
        static void Main(string[] args)
        {

            StopWatch.Start();
            Thread.Sleep(100);
            StopWatch.LapStop();
            Thread.Sleep(200);
            StopWatch.LapStop();

            StopWatch.Stop();
            StopWatch.DisplayAll();

            Console.ReadLine();
        }
    }
}
