using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CronomtroFísica;
using System.Diagnostics;
using System.Threading;
using CronomtroFísica.Controllers;
using System.IO.Ports;

namespace CronomtroFísica
{
    public partial class Form1 : Form
    {
        public bool parado;
        TimerController controller = new TimerController();
        string mensagem;

        SerialPort porta;

        public Form1()
        {
            InitializeComponent();
            controller = new TimerController();
            parado = true;
        }

        private void Iniciar_Contagem(object sender, EventArgs e)
        {
            mensagem = porta.ReadLine();

            if(mensagem == "1\r")
            {
                mensagem = controller.Start();
                parado = false;
            }
            else
            {
                mensagem = controller.Stop();
                parado = true;
            }

            this.Invoke(new EventHandler(Escrever));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            porta = new SerialPort();
            porta.BaudRate = 9600;
            porta.PortName = "COM4";
            porta.Parity = Parity.None;
            porta.DataBits = 8;
            porta.StopBits = StopBits.One;
            porta.DataReceived += Iniciar_Contagem;

            porta.Open();
        }

        private void Escrever(object sender, EventArgs e)
        {
            listCounts.Items.Add(mensagem);


            //if (parado)
            //{
            //    listCounts.Items.Add(controller.Start());
            //    parado = false;
            //}
            //else
            //{
            //    listCounts.Items.Add(controller.Stop());
            //    parado = true;
            //}
        }
    }
}
