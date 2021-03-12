using System;
using System.Collections.Generic;

namespace Stopwatch
{
    public class Stopwatch
    {
        public bool IsRunning { get; private set; }
        public TimeSpan TotalDuration { get; private set; }
        public TimeSpan ElapsedTime 
        { 
            get 
            { 
                if (Times.Count > 0)
                {
                    return DateTime.Now - Times[^1];
                }
                else
                {
                    return TimeSpan.Zero;
                }
            }
        }
        private List<DateTime> Times { get; set; }
        private List<TimeSpan> Durations { get; set; }

        public Stopwatch()
        {
            Times = new List<DateTime>();
            Durations = new List<TimeSpan>();
            TotalDuration = new TimeSpan();
        }

        public void Start()
        {
            if (!IsRunning) // If stopwatch is already running, no op.
            {
                IsRunning = true;

                Times.Add(DateTime.Now);
            }
        }

        public void Stop()
        {
            if (IsRunning) // If stopwatch isn't running, no op.
            {
                IsRunning = false;
                Times.Add(DateTime.Now);

                TimeSpan lap = Times[^1] - Times[^2];

                Durations.Add(lap);
                TotalDuration += lap;
            }
        }

        public void Reset()
        {
            if (!IsRunning) // If stopwatch is running, no op.
            {
                Times.Clear();
                Durations.Clear();
                TotalDuration = TimeSpan.Zero;
            }
        }
    }
}
