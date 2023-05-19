using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm tt");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("MMM-dd-yyyy");
            label4.Text = DateTime.Now.ToString("ddddd");
            progressBar1.Value = DateTime.Now.Hour;
            progressBar2.Value = DateTime.Now.Minute;
            progressBar3.Value = DateTime.Now.Second;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Abdullah Safwan Hashmi (A.S.H)" + Environment.NewLine + "jonesanderson768@gmail.com");
            this.Close();
        }
    }
}
