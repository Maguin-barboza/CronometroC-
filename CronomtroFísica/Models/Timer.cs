using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronomtroFísica.Models
{
    public class Timer
    {
        private Stopwatch timer;

        public Timer()
        {
            timer = new Stopwatch();
        }

        public void StartCount()
        {
            timer.Start();
        }

        public long StopCount()
        {
            long StopTime;

            timer.Stop();
            StopTime = timer.ElapsedMilliseconds;
            RestartCount();
            return StopTime;
        }

        private void RestartCount()
        {
            timer.Reset();
        }
    }
}
