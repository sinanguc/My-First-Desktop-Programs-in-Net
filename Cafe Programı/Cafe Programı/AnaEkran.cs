using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Programı
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisEkrani frm = new SiparisEkrani();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToplamKazanc frm = new ToplamKazanc();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HesapKapama frm = new HesapKapama();
            frm.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Today.ToLongDateString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.google.com"); 
        }
    }
}
