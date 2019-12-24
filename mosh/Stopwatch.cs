using System;
using System.Collections.Generic;

namespace StopWatch
{
    class StopWatch
    {
        private static DateTime _start;
        private static DateTime _stop;
        private static bool _running;
        private static int _laps;
        private static List<DateTime> _lapTimes = new List<DateTime>();

        public static void Start()
        {
            if (_running)
                StopWatchException.AlreadyStartedException();
            _start = DateTime.Now;
            _running = true;
        }
        public static void Stop()
        {
            if (!_running)
                StopWatchException.NotStartedException();
            _stop = DateTime.Now;
            _running = false;
        }
        public static TimeSpan GetDuration()
        {
            if (_running)
                StopWatchException.NotStoppedExeption();
            if (_start == _stop)
                StopWatchException.NotStartedException();
            return _stop - _start;
        }
        public static void LapStop()
        {
            if (!_running)
                StopWatchException.NotStartedException();
            _laps++;
            _lapTimes.Add(DateTime.Now);
        }
        public static void DisplayAll()
        {
            if (_running)
                StopWatchException.NotStoppedExeption();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"started: {_start}");
            for (int i = 0; i < _lapTimes.Count; i++)
            {
                Console.WriteLine($"lap {i + 1}: {_lapTimes[i]}");
            }
            Console.WriteLine($"stopped: {_stop}");
            Console.WriteLine($"full duration was: {GetDuration()}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
