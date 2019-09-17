using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CronomtroFísica.Models
{
    public class Device
    {
        private SerialPort port;
        public string portName { get { return port.PortName; } set { port.PortName = value; } }
        public int BaudRate { get { return port.BaudRate; } set { port.BaudRate = value; } }

        public Device()
        {
            port = new SerialPort();
        }

        public void Open()
        {
            try
            {
                port.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            port.Close();
        }

        public bool IsOpen()
        {
            return port.IsOpen;
        }
    }
}
