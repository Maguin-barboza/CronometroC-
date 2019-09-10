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

namespace CronomtroFísica
{
    public partial class Form1 : Form
    {
        public bool parado;
        TimerController controller = new TimerController();

        public Form1()
        {
            InitializeComponent();
            controller = new TimerController();
            parado = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (parado)
            {
                listCounts.Items.Add(controller.Start());
                parado = false;
            }
            else
            {
                listCounts.Items.Add(controller.Stop());
                parado = true;
            }
        }
    }
}
