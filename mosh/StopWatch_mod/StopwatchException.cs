using System;

namespace StopWatch
{
    class StopWatchException
    {
        public static void NotStartedException()
        {
            throw new InvalidOperationException("Stopwatch should be stopped");
        }
        public static void NotStoppedExeption()
        {
            throw new InvalidOperationException("Stopwatch should be stopped");
        }
        public static void AlreadyStartedException()
        {
            throw new InvalidOperationException("Stopwatch already started");
        }
    }
}
