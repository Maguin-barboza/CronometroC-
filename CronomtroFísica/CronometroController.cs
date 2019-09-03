using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CronomtroFísica
{
    class CronometroController
    {
        private Stopwatch stopwatch;


        public CronometroController()
        {
            stopwatch = new Stopwatch();
        }

        public string InciarCronometro()
        {
            stopwatch.Start();

            return stopwatch.Elapsed.ToString();
        }
    }
}
