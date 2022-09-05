using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            pbStop.Enabled = false;
            txtStatus.Text = "Server nije pokrenut!";
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            s?.Stop();
            Environment.Exit(0);
        }          

        private void pbStart_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.Start())
            {
                pbStart.Enabled = false;
                pbStop.Enabled = true;
                txtStatus.Text = "Server je pokrenut!";
                Thread nit = new Thread(s.Listen);
                nit.IsBackground = true;
                nit.Start();
            }
            else
            {
                MessageBox.Show("Server nije mogao da se pokrene!");
            }
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            s?.Stop();
            s = null;
            pbStart.Enabled = true;
            pbStop.Enabled = false;
            txtStatus.Text = "Server nije pokrenut!";
        }
    }
}
