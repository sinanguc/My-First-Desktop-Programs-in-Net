using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DershaneLib;

namespace Dershane
{
    public partial class DevamsizlikDuzenle : Form
    {
        Devamsizlik devam = new Devamsizlik();
        public DevamsizlikDuzenle()
        {
            InitializeComponent();
        }

        public DevamsizlikDuzenle(Devamsizlik devam)
        {
            InitializeComponent();
            this.devam = devam;
            return;
        }

        private void DevamsizlikDuzenle_Load(object sender, EventArgs e)
        {
            txtDevamsizSaat.Text = devam.DersSaat.ToString();
            dtDevamsizlik.Value = devam.DevamsizlikTarih;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDevamsizSaat_Enter(object sender, EventArgs e)
        {
            txtDevamsizSaat.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtDevamsizSaat_Leave(object sender, EventArgs e)
        {
            txtDevamsizSaat.BackColor = System.Drawing.Color.White;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDevamsizSaat.Text != "")
            {
                devam.DevamsizlikTarih = dtDevamsizlik.Value;
                devam.DersSaat = int.Parse(txtDevamsizSaat.Text);

                devam.Duzenle();

                this.Close();
            }
            else
            {
                MessageBox.Show("Devamsızlık Saati Boş Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
        }
    }
}
