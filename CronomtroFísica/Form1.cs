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

namespace CronomtroFísica
{
    public partial class Form1 : Form
    {
        //private CronometroController control;
        

        public Form1()
        {
            InitializeComponent();
            //control = new CronometroController();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 120; i++)
            {
                lblSegundos.Text = i.ToString();
                if (lblSegundos.Text == "60")
                {
                    lblMinutos.Text = (Convert.ToInt32(lblMinutos.Text) + 1).ToString();
                    lblSegundos.Text = "0";
                }
            }
        }
    }
}
