class Stopwatch
    {
        private static DateTime _start;
        private static DateTime _stop;
        private static bool _isRunning;

        public static void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch has already been started");
            _start = DateTime.Now;
            _isRunning = true;

        }
        public static void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch was never started");
            _stop = DateTime.Now;
            _isRunning = false;

        }
        public static TimeSpan GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch should be stopped");
            if (_start == _stop)
                throw new InvalidOperationException("Stopwatch was never started");
            return _stop - _start;
        }
    }
