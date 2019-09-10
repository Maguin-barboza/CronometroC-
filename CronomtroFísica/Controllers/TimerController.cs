using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CronomtroFísica.Models;

namespace CronomtroFísica.Controllers
{
    public class TimerController
    {
        private Timer timer;

        public TimerController()
        {
            timer = new Timer();
        }


        public string Start()
        {
            timer.StartCount();

            return "Objeto passou pelo primeiro sensor!";
        }

        public string Stop()
        {
            long StopTime;

            StopTime = timer.StopCount();
            return $"Objeto passou pelo segundo sensor aos {StopTime} ms.";
        }
    }
}
