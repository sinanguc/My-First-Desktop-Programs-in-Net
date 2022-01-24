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
    public partial class KursDuzenle : Form
    {
        /*Burada Kurs Listesinden Seçilen Kurs Adı
         *Düzenlenmektedir...
         */
        Kurs kurslar = new Kurs();
        public KursDuzenle()
        {
            InitializeComponent();
        }

        public KursDuzenle(Kurs kurslar) //Düzenlecek Kurs Alınıyor...
        {
            InitializeComponent();
            this.kurslar = kurslar;
            return;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KursDuzenle_Load(object sender, EventArgs e)
        {
            //Düzenlenecek Kurs TextBox a Dolduruluyor...
            txtKursAdi.Text = kurslar.KursAdi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Kurs Adı Düzenlenmesi Yapılıyor....
            kurslar.KursAdi = txtKursAdi.Text;
            kurslar.Duzenle();
            this.Close();
        }
    }
}
