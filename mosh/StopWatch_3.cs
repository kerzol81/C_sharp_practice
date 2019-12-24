class Stopwatch
    {
        private static DateTime _start;
        private static DateTime _stop;
        private static bool _running;
        private static int _laps;
        private static List<DateTime> _lapTimes = new List<DateTime>();

        public static void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch has already been started");
            _start = DateTime.Now;
            _running = true;

        }
        public static void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch was never started");
            _stop = DateTime.Now;
            _running = false;

        }
        public static TimeSpan GetDuration()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch should be stopped");
            if (_start == _stop)
                throw new InvalidOperationException("Stopwatch was never started");
            return _stop - _start;
        }
        public static void LapStop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch was never started");
            _laps++;
            _lapTimes.Add(DateTime.Now);
        }
        public static void DisplayAll() 
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch should be stopped");

            Console.WriteLine($"started: {_start}");
            for (int i = 0; i < _lapTimes.Count; i++)
            {
                Console.WriteLine($"lap {i + 1}: {_lapTimes[i]}");
            }
            Console.WriteLine($"stopped: {_stop}");
            Console.WriteLine($"full duration was: {GetDuration()}");
        }
    }
