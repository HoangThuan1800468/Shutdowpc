using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shutdowpc
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            LoadStatusbar();
        }
       
        decimal downtime = 0;
        string lenh = "Waiting....";
        string thoigianne = "";
        void LoadStatusbar()
        {
            
            labelbar.Text = lenh;
            thoigianbar.Text = thoigianne;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nmgiay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nmphut.Value++;
                box.Value = 0;
            }
        }

        private void nmphut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nmphut.Value++;
                box.Value = 0;
            }
        }
        void shutdown(string command)
        {
            System.Diagnostics.Process.Start("shutdown ", command);
        }

        void time()
        {
            downtime = nmgiay.Value + (nmphut.Value * 60) + (nmgio.Value * 60 * 60);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            shutdown("-a");
            labelbar.Text = "Waiting...";
            thoigianbar.Text = "";
            timer1.Stop();
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            time();
            shutdown("-s -t "+ downtime.ToString());
            labelbar.Text = "Shutdownting...";
            timer1.Start();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            time();
            shutdown("-r -t " + downtime.ToString());
            labelbar.Text = "Restarting...";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downtime--;
            thoigianbar.Text = downtime.ToString();
        }
    }
}
