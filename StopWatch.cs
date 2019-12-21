namespace StopWatch_2
{
    class StopWatch
    {
        private DateTime start_time;
        private DateTime stop_time;
        private bool running;

        public StopWatch()
        {
            running = false;
        }
        public void Start()
        {
            if (running)
            {
                throw new InvalidOperationException("instance already started");
            }
            else
            {
                start_time = DateTime.Now;
                running = true;
            }       
        }
        public void Stop() {    
            if (!running)
            {
                throw new InvalidOperationException("instance is not started");
            }
            else
            {
                stop_time = DateTime.Now;
            }
            running = false;
        }
        public TimeSpan GetDuration()
        {
            return stop_time - start_time;
        }
    }
}
