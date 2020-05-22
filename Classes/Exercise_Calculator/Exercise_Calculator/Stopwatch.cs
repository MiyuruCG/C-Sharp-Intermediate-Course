using System;

namespace Exercise_Calculator
{
    class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan duration;

        public void Start()
        {
            startTime = DateTime.Now;
           
        }

        public TimeSpan Stop()
        {
            endTime = DateTime.Now;
            duration = endTime - startTime;

            return duration;
        }

        public TimeSpan GetDuration()
        {
            return duration;
        }

    }
}
