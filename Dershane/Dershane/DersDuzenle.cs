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
    public partial class DersDuzenle : Form
    {
        /*Burada Ders Listesinden Seçilen Ders Adı
         *Düzenlenmektedir...
         */
        Ders dersler = new Ders();
        public DersDuzenle()
        {
            InitializeComponent();
        }

        public DersDuzenle(Ders dersler) //Seçili Dersi Al
        {
            InitializeComponent();
            this.dersler = dersler;
            return;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Ders Düzenleniyor....
            dersler.DersAdi = txtDersAdi.Text;
            dersler.Duzenle();
            this.Close();
        }

        private void DersDuzenle_Load(object sender, EventArgs e)
        {
            //Düzenlecek Ders TextBox a Dolduruluyor
            txtDersAdi.Text = dersler.DersAdi;
        }
    }
}
