using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QR_Barcode_Olustur
{
    public partial class acılıs : Form
    {
        public acılıs()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            timer1.Stop();



        }

        private void acılıs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void acılıs_Load(object sender, EventArgs e)
        {

        }
    }
}
